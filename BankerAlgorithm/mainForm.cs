using System.Globalization;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace BankerAlgorithm
{
    public partial class mainForm : Form
    {

        public int iter = 0;


        public mainForm()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            
            bool resourceOk = int.TryParse(numResourcesTextBox.Text, out global.numResources);
            bool processOk = int.TryParse(numProcessesTextBox.Text, out global.numProcesses);
           // this.Controls.Clear();
            if (!resourceOk | global.numResources>10 | !processOk | global.numProcesses>5) //Cannot take more than 5 processes and 10 resources
            {
                MessageBox.Show("Invalid entered numbers ");
                numResourcesTextBox.Clear();
                numProcessesTextBox.Clear();
                return;
            }

            int pointX = 550;
            int pointY = 110;
            for (int i = 0; i < global.numResources; i++)
            { 
                Label lbl=new Label();
                lbl.Text = "R" + (i + 1).ToString();
                lbl.Location = new Point(pointX, pointY);
                Controls.Add(lbl);
                pointX += 140;

            }

            pointX = 550;
            pointY = 150;
            int pointY2 = 230;
      
            for (int i=0;i<global.numResources;i++) {
               
                TextBox txt = new TextBox();
                TextBox txt1 = new TextBox();
                txt.Name = "resT"+i.ToString();
                txt.Text = null;
                txt.Location= new Point(pointX, pointY);
                
                
                txt1.Name = "resA" + i.ToString();
                txt1.Text = null;
                txt1.Location = new Point(pointX, pointY2);
                txt1.ReadOnly = true;
                Controls.Add(txt);
                Controls.Add(txt1);

                pointX += 140;
            }

            pointX = 550;
            pointY = 310;
            pointY2 = 510;

            for (int i=0;i< global.numProcesses;i++) {
                Label lbl = new Label();
                lbl.Text = "P" + (i+1).ToString();
                lbl.Width = 25;
                lbl.Height = 20;

                lbl.Location = new Point(pointX-30, pointY);
                Controls.Add(lbl);
                Label lbl2 = new Label();
                lbl2.Text = "P" + (i + 1).ToString();
                lbl2.Width = 25;
                lbl2.Height = 20;
                lbl2.Location = new Point(pointX-30, pointY2);
                Controls.Add(lbl2);


                for (int j=0;j<global.numResources;j++)
                {
                    TextBox txt = new TextBox();
                    TextBox txt1 = new TextBox();
                    txt.Name = "cur" +iter.ToString();//i is process# j is res#
                    txt.Text = null;
                    txt.Location = new Point(pointX, pointY);

                    txt1.Name = "max" + iter.ToString();
                    txt1.Text = null;
                    txt1.Location = new Point(pointX, pointY2);
                    Controls.Add(txt);
                    Controls.Add(txt1);
                    pointX += 140;
                    iter++;


                }
                pointX = 550;
                pointY += 35;
                pointY2 += 35;
            
            }
            button1.Enabled= true;
        }
       
        private void insertionButton_Click(object sender, EventArgs e)
        {
             global.resTotal = new int[global.numResources];

            for (int i = 0; i < global.numResources; i++)
            {
                if (Controls["resT" + i.ToString()].Text.Length > 0)
                    global.resTotal[i] = int.Parse(Controls["resT" + i.ToString()].Text);
                else 
                { 
                MessageBox.Show("Enter correct numbers ");
                return;
                }

            }
                global.resAvailable = new int[global.numResources];
            for (int i = 0; i < global.numResources; i++)
            {
                if (Controls["resA" + i.ToString()].Text.Length > 0)
                    global.resAvailable[i] = int.Parse(Controls["resA" + i.ToString()].Text);
                else
                {
                    MessageBox.Show("Enter correct numbers ");
                    return;
                }
            }
            iter = 0;
            global.currentAllocations = new int[global.numProcesses,global.numResources];
            for (int i = 0; i <global.numProcesses; i++)
            {
                for (int j = 0; j < global.numResources; j++)
                {
                    if (Controls["cur" + iter.ToString()].Text.Length > 0)
                    {
                        global.currentAllocations[i,j] = int.Parse(Controls["cur" + iter.ToString()].Text);
                        iter++;
                    }
                    else
                    {
                        MessageBox.Show("Enter correct numbers ");
                        return;
                    }
                }
            }
            iter = 0;
            global.maxNeed = new int[global.numProcesses, global.numResources];
            for (int i = 0; i < global.numProcesses; i++)
            {
                for (int j = 0; j < global.numResources; j++)
                {
                    if (Controls["max" +iter.ToString()].Text.Length > 0)
                    {
                        global.maxNeed[i,j] = int.Parse(Controls["max" +iter.ToString()].Text);
                        iter++;

                    }
                    else
                    {
                        MessageBox.Show("Enter correct numbers ");
                        return;
                    }

                }
            }
            remainingNeed remNeed = new remainingNeed();
            remNeed.ShowDialog();
            
        }

        private void AvailableResourcesCalculationClick(object sender, EventArgs e)
        {
            for (int i = 0; i < global.numResources; i++) 
            {
                iter = i;
                int total = 0;
                if (Controls["resT" + i.ToString()].Text.Length > 0) //check if there is value putted in available resources
                {
                    total = int.Parse(Controls["resT" + i.ToString()].Text.ToString());
                }

                for (int j = 0; j < global.numProcesses; j++)
                {
                    //AVAILABLE + CURRENT
                    if (Controls["cur" + iter.ToString()].Text.Length > 0)
                    {
                        total -= int.Parse(Controls["cur" + iter.ToString()].Text.ToString());
                        iter += global.numResources;
                    }
                    else
                    {
                        MessageBox.Show("Enter correct numbers ");
                        return;
                    }
                }
               
                Controls["resA" + i.ToString()].Text = total.ToString();
            }
            insertionButton.Enabled = true;
            enterButton.Enabled = false;
        }
    }
}


