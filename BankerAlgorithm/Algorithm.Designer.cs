﻿namespace BankerAlgorithm
{
    partial class Algorithm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BankerAlgoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.messageText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BankerAlgoButton
            // 
            this.BankerAlgoButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BankerAlgoButton.Location = new System.Drawing.Point(400, 500);
            this.BankerAlgoButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BankerAlgoButton.Name = "BankerAlgoButton";
            this.BankerAlgoButton.Size = new System.Drawing.Size(110, 82);
            this.BankerAlgoButton.TabIndex = 0;
            this.BankerAlgoButton.Text = "DO BANKER\'S ALGORITHM";
            this.BankerAlgoButton.UseVisualStyleBackColor = true;
            this.BankerAlgoButton.Click += new System.EventHandler(this.nextStep_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(60, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "AVAILABLE RESOURCES:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(60, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "REMAINING NEED";
            // 
            // messageText
            // 
            this.messageText.AutoSize = true;
            this.messageText.Location = new System.Drawing.Point(600, 400);
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(0, 20);
            this.messageText.TabIndex = 3;
            // 
            // Algorithm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.messageText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BankerAlgoButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Algorithm";
            this.Text = "Algorithm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BankerAlgoButton;
        private Label label1;
        private Label label2;
        private Label messageText;
    }
}