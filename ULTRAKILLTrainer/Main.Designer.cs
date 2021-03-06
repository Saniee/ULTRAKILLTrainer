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
            this.OneShot = new System.Windows.Forms.CheckBox();
            this.InfJump = new System.Windows.Forms.CheckBox();
            this.walkSpeedBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.jumpForceBar = new System.Windows.Forms.TrackBar();
            this.InfCoins = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.walkSpeedBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumpForceBar)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(118, 209);
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
            this.ProcOpenLabel.Location = new System.Drawing.Point(118, 230);
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
            this.pictureBox1.Location = new System.Drawing.Point(12, 209);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 42);
            this.label2.TabIndex = 7;
            this.label2.Text = "Made By\r\nSaniee#0007";
            // 
            // OneShot
            // 
            this.OneShot.AutoSize = true;
            this.OneShot.Location = new System.Drawing.Point(12, 136);
            this.OneShot.Name = "OneShot";
            this.OneShot.Size = new System.Drawing.Size(156, 25);
            this.OneShot.TabIndex = 8;
            this.OneShot.Text = "One Shot Enemies";
            this.OneShot.UseVisualStyleBackColor = true;
            this.OneShot.CheckedChanged += new System.EventHandler(this.OneShot_CheckedChanged);
            // 
            // InfJump
            // 
            this.InfJump.AutoSize = true;
            this.InfJump.Location = new System.Drawing.Point(12, 167);
            this.InfJump.Name = "InfJump";
            this.InfJump.Size = new System.Drawing.Size(119, 25);
            this.InfJump.TabIndex = 9;
            this.InfJump.Text = "Infinite Jump";
            this.InfJump.UseVisualStyleBackColor = true;
            this.InfJump.CheckedChanged += new System.EventHandler(this.InfJump_CheckedChanged);
            // 
            // walkSpeedBar
            // 
            this.walkSpeedBar.LargeChange = 250;
            this.walkSpeedBar.Location = new System.Drawing.Point(242, 185);
            this.walkSpeedBar.Maximum = 1500;
            this.walkSpeedBar.Minimum = 750;
            this.walkSpeedBar.Name = "walkSpeedBar";
            this.walkSpeedBar.Size = new System.Drawing.Size(178, 45);
            this.walkSpeedBar.SmallChange = 100;
            this.walkSpeedBar.TabIndex = 10;
            this.walkSpeedBar.Value = 750;
            this.walkSpeedBar.ValueChanged += new System.EventHandler(this.walkSpeedBar_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Walk Speed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Jump Force";
            // 
            // jumpForceBar
            // 
            this.jumpForceBar.Location = new System.Drawing.Point(242, 267);
            this.jumpForceBar.Maximum = 180;
            this.jumpForceBar.Minimum = 90;
            this.jumpForceBar.Name = "jumpForceBar";
            this.jumpForceBar.Size = new System.Drawing.Size(178, 45);
            this.jumpForceBar.TabIndex = 13;
            this.jumpForceBar.Value = 90;
            this.jumpForceBar.ValueChanged += new System.EventHandler(this.jumpForceBar_ValueChanged);
            // 
            // InfCoins
            // 
            this.InfCoins.AutoSize = true;
            this.InfCoins.Location = new System.Drawing.Point(230, 12);
            this.InfCoins.Name = "InfCoins";
            this.InfCoins.Size = new System.Drawing.Size(120, 25);
            this.InfCoins.TabIndex = 14;
            this.InfCoins.Text = "Infinite Coins";
            this.InfCoins.UseVisualStyleBackColor = true;
            this.InfCoins.CheckedChanged += new System.EventHandler(this.InfCoins_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 321);
            this.Controls.Add(this.InfCoins);
            this.Controls.Add(this.jumpForceBar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.walkSpeedBar);
            this.Controls.Add(this.InfJump);
            this.Controls.Add(this.OneShot);
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
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "Main";
            this.Text = "ULTRAKILL Trainer";
            this.Shown += new System.EventHandler(this.Main_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.walkSpeedBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumpForceBar)).EndInit();
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
        private CheckBox OneShot;
        private CheckBox InfJump;
        private TrackBar walkSpeedBar;
        private Label label3;
        private Label label4;
        private TrackBar jumpForceBar;
        private CheckBox InfCoins;
    }
}