using static System.Net.Mime.MediaTypeNames;

namespace BankerAlgorithm
{
    public partial class remainingNeed : Form
    {
        public remainingNeed()
        {
            InitializeComponent();

            int pointX = 50;
            int pointY = 100;
            global.remainingNeed = new int[global.numProcesses, global.numResources];
            for (int i = 0; i < global.numProcesses; i++)
            { 
                for(int j=0; j < global.numResources; j++)
                {
                    global.remainingNeed[i,j] = global.maxNeed[i, j] - global.currentAllocations[i, j];
                    TextBox text = new TextBox();
                    text.Name = "rem" + i.ToString() + j.ToString();//i is process# j is res#
                    text.Text = global.remainingNeed[i, j].ToString();
                    text.Location = new Point(pointX, pointY);
                    text.ReadOnly = true;
                    Controls.Add(text);
                    pointX += 140;
                }
                pointX = 50;
                pointY += 35;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Algorithm algo = new Algorithm();
            algo.ShowDialog();
        }
    }
}
