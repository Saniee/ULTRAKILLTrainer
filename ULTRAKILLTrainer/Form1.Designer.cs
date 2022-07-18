namespace ULTRAKILLTrainer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ErrorCodeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GithubIssues = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProblemLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ErrorCodeLabel
            // 
            this.ErrorCodeLabel.AutoSize = true;
            this.ErrorCodeLabel.Location = new System.Drawing.Point(106, 131);
            this.ErrorCodeLabel.Name = "ErrorCodeLabel";
            this.ErrorCodeLabel.Size = new System.Drawing.Size(51, 21);
            this.ErrorCodeLabel.TabIndex = 0;
            this.ErrorCodeLabel.Text = "CODE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Error Code:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(283, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Uh oh- Seems an error happened!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "To report this issue go here:";
            // 
            // GithubIssues
            // 
            this.GithubIssues.AutoSize = true;
            this.GithubIssues.Location = new System.Drawing.Point(218, 30);
            this.GithubIssues.Name = "GithubIssues";
            this.GithubIssues.Size = new System.Drawing.Size(103, 21);
            this.GithubIssues.TabIndex = 5;
            this.GithubIssues.TabStop = true;
            this.GithubIssues.Text = "Github Issues";
            this.GithubIssues.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GithubIssues_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "You can press \"Back\" to continue.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Problem with:";
            // 
            // ProblemLabel
            // 
            this.ProblemLabel.AutoSize = true;
            this.ProblemLabel.Location = new System.Drawing.Point(124, 110);
            this.ProblemLabel.Name = "ProblemLabel";
            this.ProblemLabel.Size = new System.Drawing.Size(80, 21);
            this.ProblemLabel.TabIndex = 8;
            this.ProblemLabel.Text = "PROBLEM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 161);
            this.ControlBox = false;
            this.Controls.Add(this.ProblemLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GithubIssues);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ErrorCodeLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Error";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ErrorCodeLabel;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private LinkLabel GithubIssues;
        private Label label4;
        private Label label5;
        private Label ProblemLabel;
    }
}