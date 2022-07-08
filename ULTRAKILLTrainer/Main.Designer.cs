namespace ULTRAKILLTrainer
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.BGWorker = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.ProcOpenLabel = new System.Windows.Forms.Label();
            this.InfHealth = new System.Windows.Forms.CheckBox();
            this.InfDash = new System.Windows.Forms.CheckBox();
            this.InfRailgun = new System.Windows.Forms.CheckBox();
            this.InfNailgun = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BGWorker
            // 
            this.BGWorker.WorkerReportsProgress = true;
            this.BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork);
            this.BGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorker_ProgressChanged);
            this.BGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWorker_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(118, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Open:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // ProcOpenLabel
            // 
            this.ProcOpenLabel.AutoSize = true;
            this.ProcOpenLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProcOpenLabel.Location = new System.Drawing.Point(118, 178);
            this.ProcOpenLabel.Name = "ProcOpenLabel";
            this.ProcOpenLabel.Size = new System.Drawing.Size(38, 21);
            this.ProcOpenLabel.TabIndex = 1;
            this.ProcOpenLabel.Text = "N/A";
            // 
            // InfHealth
            // 
            this.InfHealth.AutoSize = true;
            this.InfHealth.Location = new System.Drawing.Point(12, 12);
            this.InfHealth.Name = "InfHealth";
            this.InfHealth.Size = new System.Drawing.Size(126, 25);
            this.InfHealth.TabIndex = 2;
            this.InfHealth.Text = "Infinite Health";
            this.InfHealth.UseVisualStyleBackColor = true;
            this.InfHealth.CheckedChanged += new System.EventHandler(this.InfHealth_CheckedChanged);
            // 
            // InfDash
            // 
            this.InfDash.AutoSize = true;
            this.InfDash.Location = new System.Drawing.Point(12, 43);
            this.InfDash.Name = "InfDash";
            this.InfDash.Size = new System.Drawing.Size(116, 25);
            this.InfDash.TabIndex = 3;
            this.InfDash.Text = "Infinite Dash";
            this.InfDash.UseVisualStyleBackColor = true;
            this.InfDash.CheckedChanged += new System.EventHandler(this.InfDash_CheckedChanged);
            // 
            // InfRailgun
            // 
            this.InfRailgun.AutoSize = true;
            this.InfRailgun.Location = new System.Drawing.Point(12, 74);
            this.InfRailgun.Name = "InfRailgun";
            this.InfRailgun.Size = new System.Drawing.Size(134, 25);
            this.InfRailgun.TabIndex = 4;
            this.InfRailgun.Text = "Infinite Railgun";
            this.InfRailgun.UseVisualStyleBackColor = true;
            this.InfRailgun.CheckedChanged += new System.EventHandler(this.InfRailgun_CheckedChanged);
            // 
            // InfNailgun
            // 
            this.InfNailgun.AutoSize = true;
            this.InfNailgun.Location = new System.Drawing.Point(12, 105);
            this.InfNailgun.Name = "InfNailgun";
            this.InfNailgun.Size = new System.Drawing.Size(187, 25);
            this.InfNailgun.TabIndex = 5;
            this.InfNailgun.Text = "Infinite Nailgun Ammo";
            this.InfNailgun.UseVisualStyleBackColor = true;
            this.InfNailgun.CheckedChanged += new System.EventHandler(this.InfNailgun_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ULTRAKILLTrainer.Properties.Resources.tenebris_vector_art;
            this.pictureBox1.Location = new System.Drawing.Point(12, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 42);
            this.label2.TabIndex = 7;
            this.label2.Text = "Made By\r\nSaniee#0007";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 266);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.InfNailgun);
            this.Controls.Add(this.InfRailgun);
            this.Controls.Add(this.InfDash);
            this.Controls.Add(this.InfHealth);
            this.Controls.Add(this.ProcOpenLabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "ULTRAKILL Trainer";
            this.Shown += new System.EventHandler(this.Main_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker BGWorker;
        private Label label1;
        private Label ProcOpenLabel;
        private CheckBox InfHealth;
        private CheckBox InfDash;
        private CheckBox InfRailgun;
        private CheckBox InfNailgun;
        private PictureBox pictureBox1;
        private Label label2;
    }
}