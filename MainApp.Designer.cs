
namespace ULTRAKILLTrainer
{
    partial class MainApp
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.infNailgunAmmoCheck = new System.Windows.Forms.CheckBox();
            this.infRevolverCoinsCheck = new System.Windows.Forms.CheckBox();
            this.infRailgunChargeCheck = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.ProcOpenLabelOne = new System.Windows.Forms.Label();
            this.RailgunChargeStatus = new System.Windows.Forms.Label();
            this.RevolverCoinsStatus = new System.Windows.Forms.Label();
            this.NailgunAmmoStatus = new System.Windows.Forms.Label();
            this.ProcOpenLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.setHealthBtn = new System.Windows.Forms.Button();
            this.HealthInputBox = new System.Windows.Forms.TextBox();
            this.freezeHealthBtn = new System.Windows.Forms.Button();
            this.infDashChargeCheck = new System.Windows.Forms.CheckBox();
            this.enableDevModeBtn = new System.Windows.Forms.Button();
            this.HealthStatusBar = new System.Windows.Forms.ProgressBar();
            this.DevModePassInput = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(625, 332);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.HealthStatusBar);
            this.tabPage1.Controls.Add(this.infDashChargeCheck);
            this.tabPage1.Controls.Add(this.freezeHealthBtn);
            this.tabPage1.Controls.Add(this.HealthInputBox);
            this.tabPage1.Controls.Add(this.setHealthBtn);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(617, 306);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Player Stuff";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "To be Implemented";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.NailgunAmmoStatus);
            this.tabPage2.Controls.Add(this.RevolverCoinsStatus);
            this.tabPage2.Controls.Add(this.RailgunChargeStatus);
            this.tabPage2.Controls.Add(this.infNailgunAmmoCheck);
            this.tabPage2.Controls.Add(this.infRevolverCoinsCheck);
            this.tabPage2.Controls.Add(this.infRailgunChargeCheck);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(617, 306);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Weapon Stuff";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // infNailgunAmmoCheck
            // 
            this.infNailgunAmmoCheck.AutoSize = true;
            this.infNailgunAmmoCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infNailgunAmmoCheck.Location = new System.Drawing.Point(3, 78);
            this.infNailgunAmmoCheck.Name = "infNailgunAmmoCheck";
            this.infNailgunAmmoCheck.Size = new System.Drawing.Size(246, 30);
            this.infNailgunAmmoCheck.TabIndex = 2;
            this.infNailgunAmmoCheck.Text = "Infinite Nailgun Ammo";
            this.infNailgunAmmoCheck.UseVisualStyleBackColor = true;
            this.infNailgunAmmoCheck.CheckedChanged += new System.EventHandler(this.infNailgunAmmoCheck_CheckedChanged);
            // 
            // infRevolverCoinsCheck
            // 
            this.infRevolverCoinsCheck.AutoSize = true;
            this.infRevolverCoinsCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infRevolverCoinsCheck.Location = new System.Drawing.Point(3, 42);
            this.infRevolverCoinsCheck.Name = "infRevolverCoinsCheck";
            this.infRevolverCoinsCheck.Size = new System.Drawing.Size(249, 30);
            this.infRevolverCoinsCheck.TabIndex = 1;
            this.infRevolverCoinsCheck.Text = "Infinite Revolver Coins";
            this.infRevolverCoinsCheck.UseVisualStyleBackColor = true;
            this.infRevolverCoinsCheck.CheckedChanged += new System.EventHandler(this.infRevolverCoinsCheck_CheckedChanged);
            // 
            // infRailgunChargeCheck
            // 
            this.infRailgunChargeCheck.AutoSize = true;
            this.infRailgunChargeCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infRailgunChargeCheck.Location = new System.Drawing.Point(3, 6);
            this.infRailgunChargeCheck.Name = "infRailgunChargeCheck";
            this.infRailgunChargeCheck.Size = new System.Drawing.Size(252, 30);
            this.infRailgunChargeCheck.TabIndex = 0;
            this.infRailgunChargeCheck.Text = "Infinite Railgun Charge";
            this.infRailgunChargeCheck.UseVisualStyleBackColor = true;
            this.infRailgunChargeCheck.CheckedChanged += new System.EventHandler(this.infRailgunChargeCheck_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(617, 306);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Other";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "To be Implemented";
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // ProcOpenLabelOne
            // 
            this.ProcOpenLabelOne.AutoSize = true;
            this.ProcOpenLabelOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcOpenLabelOne.Location = new System.Drawing.Point(11, 347);
            this.ProcOpenLabelOne.Name = "ProcOpenLabelOne";
            this.ProcOpenLabelOne.Size = new System.Drawing.Size(149, 26);
            this.ProcOpenLabelOne.TabIndex = 1;
            this.ProcOpenLabelOne.Text = "Game Open?:";
            // 
            // RailgunChargeStatus
            // 
            this.RailgunChargeStatus.AutoSize = true;
            this.RailgunChargeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RailgunChargeStatus.Location = new System.Drawing.Point(546, 3);
            this.RailgunChargeStatus.Name = "RailgunChargeStatus";
            this.RailgunChargeStatus.Size = new System.Drawing.Size(68, 26);
            this.RailgunChargeStatus.TabIndex = 3;
            this.RailgunChargeStatus.Text = "100%";
            // 
            // RevolverCoinsStatus
            // 
            this.RevolverCoinsStatus.AutoSize = true;
            this.RevolverCoinsStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RevolverCoinsStatus.Location = new System.Drawing.Point(546, 29);
            this.RevolverCoinsStatus.Name = "RevolverCoinsStatus";
            this.RevolverCoinsStatus.Size = new System.Drawing.Size(24, 26);
            this.RevolverCoinsStatus.TabIndex = 4;
            this.RevolverCoinsStatus.Text = "4";
            // 
            // NailgunAmmoStatus
            // 
            this.NailgunAmmoStatus.AutoSize = true;
            this.NailgunAmmoStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NailgunAmmoStatus.Location = new System.Drawing.Point(546, 55);
            this.NailgunAmmoStatus.Name = "NailgunAmmoStatus";
            this.NailgunAmmoStatus.Size = new System.Drawing.Size(48, 26);
            this.NailgunAmmoStatus.TabIndex = 5;
            this.NailgunAmmoStatus.Text = "100";
            // 
            // ProcOpenLabel
            // 
            this.ProcOpenLabel.AutoSize = true;
            this.ProcOpenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcOpenLabel.ForeColor = System.Drawing.Color.Red;
            this.ProcOpenLabel.Location = new System.Drawing.Point(153, 347);
            this.ProcOpenLabel.Name = "ProcOpenLabel";
            this.ProcOpenLabel.Size = new System.Drawing.Size(49, 26);
            this.ProcOpenLabel.TabIndex = 2;
            this.ProcOpenLabel.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(382, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Railgun Charge:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(382, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Revolver Coins:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(382, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nailgun Ammo:";
            // 
            // setHealthBtn
            // 
            this.setHealthBtn.Enabled = false;
            this.setHealthBtn.Location = new System.Drawing.Point(190, 4);
            this.setHealthBtn.Name = "setHealthBtn";
            this.setHealthBtn.Size = new System.Drawing.Size(75, 23);
            this.setHealthBtn.TabIndex = 1;
            this.setHealthBtn.Text = "Set Health";
            this.setHealthBtn.UseVisualStyleBackColor = true;
            // 
            // HealthInputBox
            // 
            this.HealthInputBox.Location = new System.Drawing.Point(6, 6);
            this.HealthInputBox.Name = "HealthInputBox";
            this.HealthInputBox.Size = new System.Drawing.Size(178, 20);
            this.HealthInputBox.TabIndex = 2;
            // 
            // freezeHealthBtn
            // 
            this.freezeHealthBtn.Enabled = false;
            this.freezeHealthBtn.Location = new System.Drawing.Point(271, 4);
            this.freezeHealthBtn.Name = "freezeHealthBtn";
            this.freezeHealthBtn.Size = new System.Drawing.Size(93, 23);
            this.freezeHealthBtn.TabIndex = 3;
            this.freezeHealthBtn.Text = "Freeze Health";
            this.freezeHealthBtn.UseVisualStyleBackColor = true;
            // 
            // infDashChargeCheck
            // 
            this.infDashChargeCheck.AutoSize = true;
            this.infDashChargeCheck.Enabled = false;
            this.infDashChargeCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infDashChargeCheck.Location = new System.Drawing.Point(6, 33);
            this.infDashChargeCheck.Name = "infDashChargeCheck";
            this.infDashChargeCheck.Size = new System.Drawing.Size(229, 30);
            this.infDashChargeCheck.TabIndex = 4;
            this.infDashChargeCheck.Text = "Infinite Dash Charge";
            this.infDashChargeCheck.UseVisualStyleBackColor = true;
            // 
            // enableDevModeBtn
            // 
            this.enableDevModeBtn.Location = new System.Drawing.Point(528, 350);
            this.enableDevModeBtn.Name = "enableDevModeBtn";
            this.enableDevModeBtn.Size = new System.Drawing.Size(105, 23);
            this.enableDevModeBtn.TabIndex = 3;
            this.enableDevModeBtn.Text = "Enable Dev Mode";
            this.enableDevModeBtn.UseVisualStyleBackColor = true;
            this.enableDevModeBtn.Click += new System.EventHandler(this.enableDevModeBtn_Click);
            // 
            // HealthStatusBar
            // 
            this.HealthStatusBar.BackColor = System.Drawing.SystemColors.Control;
            this.HealthStatusBar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.HealthStatusBar.Location = new System.Drawing.Point(370, 4);
            this.HealthStatusBar.Name = "HealthStatusBar";
            this.HealthStatusBar.Size = new System.Drawing.Size(241, 23);
            this.HealthStatusBar.TabIndex = 5;
            // 
            // DevModePassInput
            // 
            this.DevModePassInput.Location = new System.Drawing.Point(422, 352);
            this.DevModePassInput.Name = "DevModePassInput";
            this.DevModePassInput.Size = new System.Drawing.Size(100, 20);
            this.DevModePassInput.TabIndex = 4;
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 381);
            this.Controls.Add(this.DevModePassInput);
            this.Controls.Add(this.enableDevModeBtn);
            this.Controls.Add(this.ProcOpenLabel);
            this.Controls.Add(this.ProcOpenLabelOne);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainApp";
            this.Text = "ULTRAKILL Trainer";
            this.Load += new System.EventHandler(this.MainApp_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox infNailgunAmmoCheck;
        private System.Windows.Forms.CheckBox infRevolverCoinsCheck;
        private System.Windows.Forms.CheckBox infRailgunChargeCheck;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.Label ProcOpenLabelOne;
        private System.Windows.Forms.Label RailgunChargeStatus;
        private System.Windows.Forms.Label NailgunAmmoStatus;
        private System.Windows.Forms.Label RevolverCoinsStatus;
        private System.Windows.Forms.Label ProcOpenLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HealthInputBox;
        private System.Windows.Forms.Button setHealthBtn;
        private System.Windows.Forms.Button freezeHealthBtn;
        private System.Windows.Forms.CheckBox infDashChargeCheck;
        private System.Windows.Forms.Button enableDevModeBtn;
        private System.Windows.Forms.ProgressBar HealthStatusBar;
        private System.Windows.Forms.TextBox DevModePassInput;
    }
}

