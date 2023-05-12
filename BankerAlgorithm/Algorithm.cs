using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankerAlgorithm
{
    public partial class Algorithm : Form
    {
        private int count = 0;
        Boolean[] visited = new Boolean[global.numProcesses]; //when process is checked and is safe too
        int[] work = new int[global.numResources];
        private Label safeSequenceLabel=new Label();

        public Algorithm()
        {
            InitializeComponent();

            //INITIAL AVAILABLE RES PRINT
            int pointX = 200;
            int pointY = 60;

            for (int i = 0; i < global.numResources; i++) //printing R0,R1,....,Rn
            {
                Label txt = new Label();
                txt.Text = "R"+(i+1).ToString();
                txt.Location = new Point(pointX, pointY);
                Controls.Add(txt);
                pointX += 140;
            }


            pointX = 200;
            pointY = 80;
            for (int i = 0; i < global.numResources; i++) //PRINTING THE VALUES OF AVAILABLE RESOURCES
            {
                TextBox txt = new TextBox();
                txt.Name = "R" + i.ToString(); 
                txt.Text = global.resAvailable[i].ToString();
                txt.Location = new Point(pointX, pointY);
                txt.ReadOnly = true;
                Controls.Add(txt);
                pointX += 140;
            }

            //INITIAL REMAINING NEEDS PRINT
            pointX = 60;
            pointY = 180;
            for (int i = 0; i < global.numProcesses; i++) // PRINTING PROCESS1,PROCESS2,.....,PROCESSn
            {
                Label text = new Label();
                text.Text = "PROCESS"+(i+1).ToString();
                text.Location = new Point(pointX, pointY);
                Controls.Add(text);
                pointY += 35;
            }

             // PRINTING REMAINING NEED VALUES
             pointX = 200;
             pointY = 180;
            for (int i = 0; i < global.numProcesses; i++)  
            {
                for (int j = 0; j < global.numResources; j++)
                {
                    TextBox text = new TextBox();
                    text.Name = "remaining" + i.ToString() + j.ToString();//i is process# j is res#
                    text.Text = global.remainingNeed[i, j].ToString();
                    text.Location = new Point(pointX, pointY);
                    text.ReadOnly = true;
                    Controls.Add(text);
                    pointX += 140;
                }
                pointX = 200;
                pointY += 35;
            }

            // visited array to find the
            // already allocated process

            for (int i = 0; i < global.numProcesses; i++)
            {
                visited[i] = false;
            }
            // work array to store the copy of
            // available resources
            
            for (int i = 0; i < global.numResources; i++)
            {
                work[i] = global.resAvailable[i];
            }
            global.safeSequence = new int[global.numProcesses];
        }
        
        private void nextStep_Click(object sender, EventArgs e)
        {
            while (count < global.numProcesses)
            {
                Boolean safeSequenceFlag = false;
                for (int i = 0; i < global.numProcesses; i++)
                {
                    if (visited[i] == false) //not checked yet
                    {
                        int j;
                        for ( j = 0; j < global.numResources; j++)
                        {
                            if (global.remainingNeed[i, j] > work[j]) // here the available resources are less than what is needed
                                break;
                        }
                        if (j == global.numResources)
                        {
                            global.safeSequence[count] = i;
                            count++;
                            visited[i] = true;
                            safeSequenceFlag = true;
                            for(j=0; j < global.numResources; j++)
                            {
                                Controls["remaining" + i.ToString() + j.ToString()].Text = "-";

                            }

                            for (j = 0; j < global.numResources; j++)
                            {
                                work[j] = work[j] + global.currentAllocations[i, j];
                                Controls["R" + j.ToString()].Text = work[j].ToString();
                                
                            }
                        }
                    }
                }


             
                if (safeSequenceFlag == false|count==global.numProcesses)
                {
                    BankerAlgoButton.Enabled = false;

                    safeSequenceLabel.Width = 300;
                    safeSequenceLabel.Height = 20;
                    safeSequenceLabel.Location = new Point(50, 500);
                    
                    if (count < global.numProcesses)
                    {
                        safeSequenceLabel.Text = "The System is UnSafe!";
                    }
                    else
                    {
                        string sequence = "";
                        for (int i = 0; i < global.numProcesses; i++)
                        {
                            sequence += "P" + global.safeSequence[i].ToString() + " ";
                        }
                        safeSequenceLabel.Text = "Safe Sequence: " + sequence;
                    }
                    Controls.Add(safeSequenceLabel);
                }
            }
                
        }


    }
}
