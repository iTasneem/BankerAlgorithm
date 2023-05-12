namespace BankerAlgorithm
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.enterButton = new System.Windows.Forms.Button();
            this.numResourcesTextBox = new System.Windows.Forms.TextBox();
            this.numProcessesTextBox = new System.Windows.Forms.TextBox();
            this.resText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.insertionButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(120, 248);
            this.enterButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(137, 56);
            this.enterButton.TabIndex = 0;
            this.enterButton.Text = "ENTER";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // numResourcesTextBox
            // 
            this.numResourcesTextBox.Location = new System.Drawing.Point(130, 115);
            this.numResourcesTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numResourcesTextBox.Name = "numResourcesTextBox";
            this.numResourcesTextBox.Size = new System.Drawing.Size(114, 27);
            this.numResourcesTextBox.TabIndex = 1;
            // 
            // numProcessesTextBox
            // 
            this.numProcessesTextBox.Location = new System.Drawing.Point(130, 173);
            this.numProcessesTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numProcessesTextBox.Name = "numProcessesTextBox";
            this.numProcessesTextBox.Size = new System.Drawing.Size(114, 27);
            this.numProcessesTextBox.TabIndex = 2;
            // 
            // resText
            // 
            this.resText.AutoSize = true;
            this.resText.Location = new System.Drawing.Point(296, 125);
            this.resText.Name = "resText";
            this.resText.Size = new System.Drawing.Size(153, 20);
            this.resText.TabIndex = 3;
            this.resText.Text = "Number Of Resources";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of Processes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(550, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Resources";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Current Allocations";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(550, 479);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Maximum need";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(550, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Available Resources";
            // 
            // insertionButton
            // 
            this.insertionButton.Enabled = false;
            this.insertionButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.insertionButton.Location = new System.Drawing.Point(120, 451);
            this.insertionButton.Name = "insertionButton";
            this.insertionButton.Size = new System.Drawing.Size(137, 77);
            this.insertionButton.TabIndex = 9;
            this.insertionButton.Text = "Insert Values";
            this.insertionButton.UseVisualStyleBackColor = true;
            this.insertionButton.Click += new System.EventHandler(this.insertionButton_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(120, 339);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 77);
            this.button1.TabIndex = 10;
            this.button1.Text = "Available resources Calculation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AvailableResourcesCalculationClick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 755);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.insertionButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resText);
            this.Controls.Add(this.numProcessesTextBox);
            this.Controls.Add(this.numResourcesTextBox);
            this.Controls.Add(this.enterButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "mainForm";
            this.Text = "EnteringData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button enterButton;
        private TextBox numResourcesTextBox;
        private TextBox numProcessesTextBox;
        private Label resText;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button insertionButton;
        private Button button1;
    }
}