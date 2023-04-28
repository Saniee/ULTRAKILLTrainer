
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
            this.PlayerPage = new System.Windows.Forms.TabPage();
            this.NoHardDamageCheck = new System.Windows.Forms.CheckBox();
            this.infDashChargeCheck = new System.Windows.Forms.CheckBox();
            this.freezeHealthBtn = new System.Windows.Forms.Button();
            this.HealthInputBox = new System.Windows.Forms.TextBox();
            this.setHealthBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.WeaponPage = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NailgunAmmoStatus = new System.Windows.Forms.Label();
            this.RevolverCoinsStatus = new System.Windows.Forms.Label();
            this.RailgunChargeStatus = new System.Windows.Forms.Label();
            this.infNailgunAmmoCheck = new System.Windows.Forms.CheckBox();
            this.infRevolverCoinsCheck = new System.Windows.Forms.CheckBox();
            this.infRailgunChargeCheck = new System.Windows.Forms.CheckBox();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.ProcOpenLabelOne = new System.Windows.Forms.Label();
            this.ProcOpenLabel = new System.Windows.Forms.Label();
            this.enablePreReleaseFeaturesBtn = new System.Windows.Forms.Button();
            this.PreReleaseFeaturesPassInput = new System.Windows.Forms.TextBox();
            this.bgPlayerActiveWorker = new System.ComponentModel.BackgroundWorker();
            this.statsPage = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.playerActive = new System.Windows.Forms.Label();
            this.setStylePointsBtn = new System.Windows.Forms.Button();
            this.setNoRestartsBtn = new System.Windows.Forms.Button();
            this.noDmgStatCheck = new System.Windows.Forms.CheckBox();
            this.StylePointInput = new System.Windows.Forms.TextBox();
            this.RestartsInput = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.PlayerPage.SuspendLayout();
            this.WeaponPage.SuspendLayout();
            this.statsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PlayerPage);
            this.tabControl1.Controls.Add(this.statsPage);
            this.tabControl1.Controls.Add(this.WeaponPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(625, 332);
            this.tabControl1.TabIndex = 0;
            // 
            // PlayerPage
            // 
            this.PlayerPage.Controls.Add(this.playerActive);
            this.PlayerPage.Controls.Add(this.NoHardDamageCheck);
            this.PlayerPage.Controls.Add(this.infDashChargeCheck);
            this.PlayerPage.Controls.Add(this.freezeHealthBtn);
            this.PlayerPage.Controls.Add(this.HealthInputBox);
            this.PlayerPage.Controls.Add(this.setHealthBtn);
            this.PlayerPage.Controls.Add(this.label1);
            this.PlayerPage.Location = new System.Drawing.Point(4, 22);
            this.PlayerPage.Name = "PlayerPage";
            this.PlayerPage.Padding = new System.Windows.Forms.Padding(3);
            this.PlayerPage.Size = new System.Drawing.Size(617, 306);
            this.PlayerPage.TabIndex = 0;
            this.PlayerPage.Text = "Player Stuff";
            this.PlayerPage.UseVisualStyleBackColor = true;
            // 
            // NoHardDamageCheck
            // 
            this.NoHardDamageCheck.AutoSize = true;
            this.NoHardDamageCheck.Enabled = false;
            this.NoHardDamageCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoHardDamageCheck.Location = new System.Drawing.Point(6, 69);
            this.NoHardDamageCheck.Name = "NoHardDamageCheck";
            this.NoHardDamageCheck.Size = new System.Drawing.Size(201, 30);
            this.NoHardDamageCheck.TabIndex = 6;
            this.NoHardDamageCheck.Text = "No Hard Damage";
            this.NoHardDamageCheck.UseVisualStyleBackColor = true;
            this.NoHardDamageCheck.CheckedChanged += new System.EventHandler(this.NoHardDamageCheck_CheckedChanged);
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
            this.infDashChargeCheck.CheckedChanged += new System.EventHandler(this.infDashChargeCheck_CheckedChanged);
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
            this.freezeHealthBtn.Click += new System.EventHandler(this.freezeHealthBtn_Click);
            // 
            // HealthInputBox
            // 
            this.HealthInputBox.Location = new System.Drawing.Point(6, 6);
            this.HealthInputBox.Name = "HealthInputBox";
            this.HealthInputBox.Size = new System.Drawing.Size(178, 20);
            this.HealthInputBox.TabIndex = 2;
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
            this.setHealthBtn.Click += new System.EventHandler(this.setHealthBtn_Click);
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
            // WeaponPage
            // 
            this.WeaponPage.Controls.Add(this.label5);
            this.WeaponPage.Controls.Add(this.label4);
            this.WeaponPage.Controls.Add(this.label3);
            this.WeaponPage.Controls.Add(this.NailgunAmmoStatus);
            this.WeaponPage.Controls.Add(this.RevolverCoinsStatus);
            this.WeaponPage.Controls.Add(this.RailgunChargeStatus);
            this.WeaponPage.Controls.Add(this.infNailgunAmmoCheck);
            this.WeaponPage.Controls.Add(this.infRevolverCoinsCheck);
            this.WeaponPage.Controls.Add(this.infRailgunChargeCheck);
            this.WeaponPage.Location = new System.Drawing.Point(4, 22);
            this.WeaponPage.Name = "WeaponPage";
            this.WeaponPage.Padding = new System.Windows.Forms.Padding(3);
            this.WeaponPage.Size = new System.Drawing.Size(617, 306);
            this.WeaponPage.TabIndex = 1;
            this.WeaponPage.Text = "Weapon Stuff";
            this.WeaponPage.UseVisualStyleBackColor = true;
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
            // enablePreReleaseFeaturesBtn
            // 
            this.enablePreReleaseFeaturesBtn.Location = new System.Drawing.Point(514, 350);
            this.enablePreReleaseFeaturesBtn.Name = "enablePreReleaseFeaturesBtn";
            this.enablePreReleaseFeaturesBtn.Size = new System.Drawing.Size(120, 25);
            this.enablePreReleaseFeaturesBtn.TabIndex = 3;
            this.enablePreReleaseFeaturesBtn.Text = "Pre-Release Features";
            this.enablePreReleaseFeaturesBtn.UseVisualStyleBackColor = true;
            this.enablePreReleaseFeaturesBtn.Click += new System.EventHandler(this.enablePreReleaseFeaturesBtn_Click);
            // 
            // PreReleaseFeaturesPassInput
            // 
            this.PreReleaseFeaturesPassInput.Location = new System.Drawing.Point(378, 353);
            this.PreReleaseFeaturesPassInput.MaxLength = 27;
            this.PreReleaseFeaturesPassInput.Name = "PreReleaseFeaturesPassInput";
            this.PreReleaseFeaturesPassInput.Size = new System.Drawing.Size(130, 20);
            this.PreReleaseFeaturesPassInput.TabIndex = 4;
            // 
            // bgPlayerActiveWorker
            // 
            this.bgPlayerActiveWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgPlayerActiveWorker_DoWork);
            this.bgPlayerActiveWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgPlayerActiveWorker_RunWorkerCompleted);
            // 
            // statsPage
            // 
            this.statsPage.Controls.Add(this.RestartsInput);
            this.statsPage.Controls.Add(this.StylePointInput);
            this.statsPage.Controls.Add(this.noDmgStatCheck);
            this.statsPage.Controls.Add(this.setNoRestartsBtn);
            this.statsPage.Controls.Add(this.setStylePointsBtn);
            this.statsPage.Controls.Add(this.label6);
            this.statsPage.Location = new System.Drawing.Point(4, 22);
            this.statsPage.Name = "statsPage";
            this.statsPage.Size = new System.Drawing.Size(617, 306);
            this.statsPage.TabIndex = 3;
            this.statsPage.Text = "Level Stats";
            this.statsPage.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(361, 46);
            this.label6.TabIndex = 1;
            this.label6.Text = "To be Implemented";
            // 
            // playerActive
            // 
            this.playerActive.AutoSize = true;
            this.playerActive.Location = new System.Drawing.Point(601, 290);
            this.playerActive.Name = "playerActive";
            this.playerActive.Size = new System.Drawing.Size(13, 13);
            this.playerActive.TabIndex = 7;
            this.playerActive.Text = "0";
            // 
            // setStylePointsBtn
            // 
            this.setStylePointsBtn.Enabled = false;
            this.setStylePointsBtn.Location = new System.Drawing.Point(172, 0);
            this.setStylePointsBtn.Name = "setStylePointsBtn";
            this.setStylePointsBtn.Size = new System.Drawing.Size(95, 25);
            this.setStylePointsBtn.TabIndex = 2;
            this.setStylePointsBtn.Text = "Set Style Points";
            this.setStylePointsBtn.UseVisualStyleBackColor = true;
            this.setStylePointsBtn.Click += new System.EventHandler(this.setStylePointsBtn_Click);
            // 
            // setNoRestartsBtn
            // 
            this.setNoRestartsBtn.Enabled = false;
            this.setNoRestartsBtn.Location = new System.Drawing.Point(172, 26);
            this.setNoRestartsBtn.Name = "setNoRestartsBtn";
            this.setNoRestartsBtn.Size = new System.Drawing.Size(110, 25);
            this.setNoRestartsBtn.TabIndex = 3;
            this.setNoRestartsBtn.Text = "Set No. of Restarts";
            this.setNoRestartsBtn.UseVisualStyleBackColor = true;
            this.setNoRestartsBtn.Click += new System.EventHandler(this.setNoRestartsBtn_Click);
            // 
            // noDmgStatCheck
            // 
            this.noDmgStatCheck.AutoSize = true;
            this.noDmgStatCheck.Enabled = false;
            this.noDmgStatCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noDmgStatCheck.Location = new System.Drawing.Point(3, 57);
            this.noDmgStatCheck.Name = "noDmgStatCheck";
            this.noDmgStatCheck.Size = new System.Drawing.Size(210, 30);
            this.noDmgStatCheck.TabIndex = 4;
            this.noDmgStatCheck.Text = "Took No Dmg Stat";
            this.noDmgStatCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.noDmgStatCheck.UseVisualStyleBackColor = true;
            this.noDmgStatCheck.CheckedChanged += new System.EventHandler(this.noDmgStatCheck_CheckedChanged);
            // 
            // StylePointInput
            // 
            this.StylePointInput.Location = new System.Drawing.Point(3, 3);
            this.StylePointInput.Name = "StylePointInput";
            this.StylePointInput.Size = new System.Drawing.Size(163, 20);
            this.StylePointInput.TabIndex = 5;
            // 
            // RestartsInput
            // 
            this.RestartsInput.Location = new System.Drawing.Point(3, 29);
            this.RestartsInput.Name = "RestartsInput";
            this.RestartsInput.Size = new System.Drawing.Size(163, 20);
            this.RestartsInput.TabIndex = 6;
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 381);
            this.Controls.Add(this.PreReleaseFeaturesPassInput);
            this.Controls.Add(this.enablePreReleaseFeaturesBtn);
            this.Controls.Add(this.ProcOpenLabel);
            this.Controls.Add(this.ProcOpenLabelOne);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainApp";
            this.Text = "ULTRAKILL Trainer";
            this.Load += new System.EventHandler(this.MainApp_Load);
            this.tabControl1.ResumeLayout(false);
            this.PlayerPage.ResumeLayout(false);
            this.PlayerPage.PerformLayout();
            this.WeaponPage.ResumeLayout(false);
            this.WeaponPage.PerformLayout();
            this.statsPage.ResumeLayout(false);
            this.statsPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PlayerPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage WeaponPage;
        private System.Windows.Forms.CheckBox infNailgunAmmoCheck;
        private System.Windows.Forms.CheckBox infRevolverCoinsCheck;
        private System.Windows.Forms.CheckBox infRailgunChargeCheck;
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
        private System.Windows.Forms.Button enablePreReleaseFeaturesBtn;
        private System.Windows.Forms.TextBox PreReleaseFeaturesPassInput;
        private System.Windows.Forms.CheckBox NoHardDamageCheck;
        private System.ComponentModel.BackgroundWorker bgPlayerActiveWorker;
        private System.Windows.Forms.TabPage statsPage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label playerActive;
        private System.Windows.Forms.Button setStylePointsBtn;
        private System.Windows.Forms.Button setNoRestartsBtn;
        private System.Windows.Forms.CheckBox noDmgStatCheck;
        private System.Windows.Forms.TextBox StylePointInput;
        private System.Windows.Forms.TextBox RestartsInput;
    }
}

