using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Memory;

namespace ULTRAKILLTrainer
{
    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();
        }

        public Mem m = new Mem();

        private string WepBase = "UnityPlayer.dll+017E1C30,0,10,88,8,58,28";
        private string PlayerBase = "UnityPlayer.dll+01801D58,10,10,30,38,28,28";
        private string StatBase = "UnityPlayer.dll+017E1C30,0,10,90,80,40,28";

        private bool gameOpen = false;
        private bool devMode = false;
        private bool healthFrozen = false;

        private string nailgunAmmoOffset = ",60";
        private string railgunChargeOffset = ",70";
        private string revolverCoinsOffset = ",48";

        private string stylePointsOffset = ",C4";
        private string tookDmgStatOffset = ",E4";
        private string noRestartsOffset = ",C8";

        private string healthOffset = ",21C";
        private string dashChargeOffset = ",28C";
        private string hardDamageOffset = ",220";
        private string playerActiveOffset = ",02B0";

        private void MainApp_Load(object sender, EventArgs e)
        {
            bgWorker.RunWorkerAsync();
            bgPlayerActiveWorker.RunWorkerAsync();
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            gameOpen = m.OpenProcess("ULTRAKILL");

            Thread.Sleep(100);
            bgWorker.ReportProgress(0);
        }

        private void bgPlayerActiveWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int readInt = m.ReadInt(PlayerBase + playerActiveOffset);
            
            Thread.Sleep(100);
            bgWorker.ReportProgress(0);
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (gameOpen)
            {
                ProcOpenLabel.ForeColor = Color.Green;
                ProcOpenLabel.Text = "Yes";
            } else
            {
                ProcOpenLabel.ForeColor = Color.Red;
                ProcOpenLabel.Text = "N/A";
                return;
            }

            // Info Labels
            RailgunChargeStatus.Text = Math.Floor(m.ReadFloat(WepBase + railgunChargeOffset) * 20).ToString() + "%"; 
            RevolverCoinsStatus.Text = Math.Floor(m.ReadFloat(WepBase + revolverCoinsOffset) / 100).ToString();
            NailgunAmmoStatus.Text = Math.Floor(m.ReadFloat(WepBase + nailgunAmmoOffset)).ToString();
            playerActive.Text = m.ReadByte(PlayerBase + ",02B0").ToString();

            if (devMode == true)
            {
                setHealthBtn.Enabled = true;
                freezeHealthBtn.Enabled = true;
                infDashChargeCheck.Enabled = true;
                NoHardDamageCheck.Enabled = true;
                setStylePointsBtn.Enabled = true;
                setNoRestartsBtn.Enabled = true;
                noDmgStatCheck.Enabled = true;
            }
            else
            {
                setHealthBtn.Enabled = false;
                freezeHealthBtn.Enabled = false;
                infDashChargeCheck.Enabled = false;
                NoHardDamageCheck.Enabled = false;
                setStylePointsBtn.Enabled = false;
                setNoRestartsBtn.Enabled = false;
                noDmgStatCheck.Enabled = false;
            }
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bgWorker.RunWorkerAsync();
        }

        private void bgPlayerActiveWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bgPlayerActiveWorker.RunWorkerAsync();
        }

        private void infRailgunChargeCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (infRailgunChargeCheck.Checked)
            {
                m.FreezeValue(WepBase + railgunChargeOffset, "float", "5");
            } else
            {
                m.UnfreezeValue(WepBase + railgunChargeOffset);
            }
        }

        private void infRevolverCoinsCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (infRevolverCoinsCheck.Checked)
            {
                m.FreezeValue(WepBase + revolverCoinsOffset, "float", "400");
            }
            else
            {
                m.UnfreezeValue(WepBase + revolverCoinsOffset);
            }
        }

        private void infNailgunAmmoCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (infNailgunAmmoCheck.Checked)
            {
                m.FreezeValue(WepBase + nailgunAmmoOffset, "float", "100");
            }
            else
            {
                m.UnfreezeValue(WepBase + nailgunAmmoOffset);
            }
        }

        private void enablePreReleaseFeaturesBtn_Click(object sender, EventArgs e)
        {
            if (PreReleaseFeaturesPassInput.Text == "WarningExperimentalFeatures")
            {
                devMode = !devMode;
                MessageBox.Show("You can now work with Pre-Release Features.", "ULTRAKILL Trainer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PreReleaseFeaturesPassInput.Text = "";
            }
            else
            {
                MessageBox.Show("Wrong Password.", "ULTRAKILL Trainer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void setHealthBtn_Click(object sender, EventArgs e)
        {
            m.WriteMemory(PlayerBase + healthOffset, "int", HealthInputBox.Text);
        }

        private void freezeHealthBtn_Click(object sender, EventArgs e)
        {
            string cHealth = m.ReadInt(PlayerBase + healthOffset).ToString();
            healthFrozen = !healthFrozen;

            if (healthFrozen)
            {
                m.FreezeValue(PlayerBase + healthOffset, "int", cHealth);
                freezeHealthBtn.ForeColor = Color.Green;
            } 
            else
            {
                m.UnfreezeValue(PlayerBase + healthOffset);
                freezeHealthBtn.ForeColor = Color.Black;
            }
        }

        private void infDashChargeCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (infDashChargeCheck.Checked)
            {
                m.FreezeValue(PlayerBase + dashChargeOffset, "float", "300");
            }
            else
            {
                m.UnfreezeValue(PlayerBase + dashChargeOffset);
            }
        }

        private void NoHardDamageCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (NoHardDamageCheck.Checked)
            {
                m.FreezeValue(PlayerBase + hardDamageOffset, "int", "0");
            }
            else
            {
                m.UnfreezeValue(PlayerBase + hardDamageOffset);
            }
        }

        private void setStylePointsBtn_Click(object sender, EventArgs e)
        {
            m.WriteMemory(StatBase + stylePointsOffset, "int", StylePointInput.Text);
        }

        private void setNoRestartsBtn_Click(object sender, EventArgs e)
        {
            m.WriteMemory(StatBase + noRestartsOffset, "int", RestartsInput.Text);
        }

        private void noDmgStatCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (noDmgStatCheck.Checked)
            {
                m.FreezeValue(StatBase + tookDmgStatOffset, "byte", "0");
            }
            else
            {
                m.UnfreezeValue(StatBase + tookDmgStatOffset);
            }
        }
    }
}
