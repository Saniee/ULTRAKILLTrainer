
namespace ULTRAKILLTrainer_Cheats
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.BGWorker = new System.ComponentModel.BackgroundWorker();
            this.ProcOpenLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.infHealth = new System.Windows.Forms.CheckBox();
            this.infDash = new System.Windows.Forms.CheckBox();
            this.infRailgun = new System.Windows.Forms.CheckBox();
            this.infNailgun = new System.Windows.Forms.CheckBox();
            this.infJump = new System.Windows.Forms.CheckBox();
            this.walkSpeedBar = new System.Windows.Forms.TrackBar();
            this.jumpForceBar = new System.Windows.Forms.TrackBar();
            this.infCoins = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.infWallJump = new System.Windows.Forms.CheckBox();
            this.noHardDmg = new System.Windows.Forms.CheckBox();
            this.pHealth = new System.Windows.Forms.Label();
            this.BGPlayerStatCheck = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.hDmg = new System.Windows.Forms.Label();
            this.railgunInfo = new System.Windows.Forms.Label();
            this.walkSpeedInfo = new System.Windows.Forms.Label();
            this.jumpForceInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.walkSpeedBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumpForceBar)).BeginInit();
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
            // ProcOpenLabel
            // 
            this.ProcOpenLabel.AutoSize = true;
            this.ProcOpenLabel.Location = new System.Drawing.Point(364, 178);
            this.ProcOpenLabel.Name = "ProcOpenLabel";
            this.ProcOpenLabel.Size = new System.Drawing.Size(27, 13);
            this.ProcOpenLabel.TabIndex = 0;
            this.ProcOpenLabel.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Game Open?:";
            // 
            // infHealth
            // 
            this.infHealth.AutoSize = true;
            this.infHealth.Location = new System.Drawing.Point(12, 12);
            this.infHealth.Name = "infHealth";
            this.infHealth.Size = new System.Drawing.Size(91, 17);
            this.infHealth.TabIndex = 2;
            this.infHealth.Text = "Infinite Health";
            this.infHealth.UseVisualStyleBackColor = true;
            this.infHealth.CheckedChanged += new System.EventHandler(this.infHealth_CheckedChanged);
            // 
            // infDash
            // 
            this.infDash.AutoSize = true;
            this.infDash.Location = new System.Drawing.Point(12, 58);
            this.infDash.Name = "infDash";
            this.infDash.Size = new System.Drawing.Size(85, 17);
            this.infDash.TabIndex = 3;
            this.infDash.Text = "Infinite Dash";
            this.infDash.UseVisualStyleBackColor = true;
            this.infDash.CheckedChanged += new System.EventHandler(this.infDash_CheckedChanged);
            // 
            // infRailgun
            // 
            this.infRailgun.AutoSize = true;
            this.infRailgun.Location = new System.Drawing.Point(12, 127);
            this.infRailgun.Name = "infRailgun";
            this.infRailgun.Size = new System.Drawing.Size(133, 17);
            this.infRailgun.TabIndex = 4;
            this.infRailgun.Text = "Infinite Railgun Charge";
            this.infRailgun.UseVisualStyleBackColor = true;
            this.infRailgun.CheckedChanged += new System.EventHandler(this.infRailgun_CheckedChanged);
            // 
            // infNailgun
            // 
            this.infNailgun.AutoSize = true;
            this.infNailgun.Location = new System.Drawing.Point(12, 150);
            this.infNailgun.Name = "infNailgun";
            this.infNailgun.Size = new System.Drawing.Size(128, 17);
            this.infNailgun.TabIndex = 5;
            this.infNailgun.Text = "Infinite Nailgun Ammo";
            this.infNailgun.UseVisualStyleBackColor = true;
            this.infNailgun.CheckedChanged += new System.EventHandler(this.infNailgun_CheckedChanged);
            // 
            // infJump
            // 
            this.infJump.AutoSize = true;
            this.infJump.Location = new System.Drawing.Point(12, 81);
            this.infJump.Name = "infJump";
            this.infJump.Size = new System.Drawing.Size(85, 17);
            this.infJump.TabIndex = 6;
            this.infJump.Text = "Infinite Jump";
            this.infJump.UseVisualStyleBackColor = true;
            this.infJump.CheckedChanged += new System.EventHandler(this.infJump_CheckedChanged);
            // 
            // walkSpeedBar
            // 
            this.walkSpeedBar.LargeChange = 250;
            this.walkSpeedBar.Location = new System.Drawing.Point(169, 31);
            this.walkSpeedBar.Maximum = 1500;
            this.walkSpeedBar.Minimum = 750;
            this.walkSpeedBar.Name = "walkSpeedBar";
            this.walkSpeedBar.Size = new System.Drawing.Size(104, 45);
            this.walkSpeedBar.SmallChange = 100;
            this.walkSpeedBar.TabIndex = 10;
            this.walkSpeedBar.Value = 750;
            this.walkSpeedBar.ValueChanged += new System.EventHandler(this.walkSpeedBar_ValueChanged);
            // 
            // jumpForceBar
            // 
            this.jumpForceBar.LargeChange = 40;
            this.jumpForceBar.Location = new System.Drawing.Point(169, 105);
            this.jumpForceBar.Maximum = 180;
            this.jumpForceBar.Minimum = 90;
            this.jumpForceBar.Name = "jumpForceBar";
            this.jumpForceBar.Size = new System.Drawing.Size(104, 45);
            this.jumpForceBar.SmallChange = 10;
            this.jumpForceBar.TabIndex = 13;
            this.jumpForceBar.Value = 90;
            this.jumpForceBar.ValueChanged += new System.EventHandler(this.jumpForceBar_ValueChanged);
            // 
            // infCoins
            // 
            this.infCoins.AutoSize = true;
            this.infCoins.Location = new System.Drawing.Point(12, 173);
            this.infCoins.Name = "infCoins";
            this.infCoins.Size = new System.Drawing.Size(86, 17);
            this.infCoins.TabIndex = 14;
            this.infCoins.Text = "Infinite Coins";
            this.infCoins.UseVisualStyleBackColor = true;
            this.infCoins.CheckedChanged += new System.EventHandler(this.infCoins_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Jump Force";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Walk Speed";
            // 
            // infWallJump
            // 
            this.infWallJump.AutoSize = true;
            this.infWallJump.Location = new System.Drawing.Point(12, 104);
            this.infWallJump.Name = "infWallJump";
            this.infWallJump.Size = new System.Drawing.Size(114, 17);
            this.infWallJump.TabIndex = 17;
            this.infWallJump.Text = "Infinite Wall Jumps";
            this.infWallJump.UseVisualStyleBackColor = true;
            this.infWallJump.CheckedChanged += new System.EventHandler(this.infWallJump_CheckedChanged);
            // 
            // noHardDmg
            // 
            this.noHardDmg.AutoSize = true;
            this.noHardDmg.Location = new System.Drawing.Point(12, 35);
            this.noHardDmg.Name = "noHardDmg";
            this.noHardDmg.Size = new System.Drawing.Size(109, 17);
            this.noHardDmg.TabIndex = 18;
            this.noHardDmg.Text = "No Hard Damage";
            this.noHardDmg.UseVisualStyleBackColor = true;
            this.noHardDmg.CheckedChanged += new System.EventHandler(this.noHardDmg_CheckedChanged);
            // 
            // pHealth
            // 
            this.pHealth.AutoSize = true;
            this.pHealth.Location = new System.Drawing.Point(292, 22);
            this.pHealth.Name = "pHealth";
            this.pHealth.Size = new System.Drawing.Size(64, 13);
            this.pHealth.TabIndex = 19;
            this.pHealth.Text = "Health: N/A";
            // 
            // BGPlayerStatCheck
            // 
            this.BGPlayerStatCheck.WorkerReportsProgress = true;
            this.BGPlayerStatCheck.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGPlayerStatCheck_DoWork);
            this.BGPlayerStatCheck.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGPlayerStatCheck_ProgressChanged);
            this.BGPlayerStatCheck.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGPlayerStatCheck_RunWorkerCompleted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Player Info:";
            // 
            // hDmg
            // 
            this.hDmg.AutoSize = true;
            this.hDmg.Location = new System.Drawing.Point(292, 35);
            this.hDmg.Name = "hDmg";
            this.hDmg.Size = new System.Drawing.Size(99, 13);
            this.hDmg.TabIndex = 21;
            this.hDmg.Text = "Hard Damage: N/A";
            // 
            // railgunInfo
            // 
            this.railgunInfo.AutoSize = true;
            this.railgunInfo.Location = new System.Drawing.Point(292, 74);
            this.railgunInfo.Name = "railgunInfo";
            this.railgunInfo.Size = new System.Drawing.Size(109, 13);
            this.railgunInfo.TabIndex = 22;
            this.railgunInfo.Text = "Railgun Ready?: N/A";
            // 
            // walkSpeedInfo
            // 
            this.walkSpeedInfo.AutoSize = true;
            this.walkSpeedInfo.Location = new System.Drawing.Point(292, 48);
            this.walkSpeedInfo.Name = "walkSpeedInfo";
            this.walkSpeedInfo.Size = new System.Drawing.Size(92, 13);
            this.walkSpeedInfo.TabIndex = 23;
            this.walkSpeedInfo.Text = "Walk Speed: N/A";
            // 
            // jumpForceInfo
            // 
            this.jumpForceInfo.AutoSize = true;
            this.jumpForceInfo.Location = new System.Drawing.Point(292, 61);
            this.jumpForceInfo.Name = "jumpForceInfo";
            this.jumpForceInfo.Size = new System.Drawing.Size(88, 13);
            this.jumpForceInfo.TabIndex = 24;
            this.jumpForceInfo.Text = "Jump Force: N/A";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ULTRAKILLTrainer.Properties.Resources.tenebris_vector_art;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(295, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Made by Saniee#0007";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 200);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.jumpForceInfo);
            this.Controls.Add(this.walkSpeedInfo);
            this.Controls.Add(this.railgunInfo);
            this.Controls.Add(this.hDmg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pHealth);
            this.Controls.Add(this.noHardDmg);
            this.Controls.Add(this.infWallJump);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.infCoins);
            this.Controls.Add(this.jumpForceBar);
            this.Controls.Add(this.walkSpeedBar);
            this.Controls.Add(this.infJump);
            this.Controls.Add(this.infNailgun);
            this.Controls.Add(this.infRailgun);
            this.Controls.Add(this.infDash);
            this.Controls.Add(this.infHealth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProcOpenLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "ULTRAKILL Trainer";
            this.Shown += new System.EventHandler(this.Main_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.walkSpeedBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumpForceBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker BGWorker;
        private System.Windows.Forms.Label ProcOpenLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox infHealth;
        private System.Windows.Forms.CheckBox infDash;
        private System.Windows.Forms.CheckBox infRailgun;
        private System.Windows.Forms.CheckBox infNailgun;
        private System.Windows.Forms.CheckBox infJump;
        private System.Windows.Forms.TrackBar walkSpeedBar;
        private System.Windows.Forms.TrackBar jumpForceBar;
        private System.Windows.Forms.CheckBox infCoins;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox infWallJump;
        private System.Windows.Forms.CheckBox noHardDmg;
        private System.Windows.Forms.Label pHealth;
        private System.ComponentModel.BackgroundWorker BGPlayerStatCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label hDmg;
        private System.Windows.Forms.Label railgunInfo;
        private System.Windows.Forms.Label walkSpeedInfo;
        private System.Windows.Forms.Label jumpForceInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}

