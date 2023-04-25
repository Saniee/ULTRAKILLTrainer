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

        string WepBase = "UnityPlayer.dll+017AB300,0,48,88,8,90,28";
        // string PlayerBase = "";

        bool gameOpen = false;
        bool devMode = false;

        string nailgunAmmoOffset = ",5C";
        string railgunChargeOffset = ",6C";
        string revolverCoinsOffset = ",48";

        private void MainApp_Load(object sender, EventArgs e)
        {
            bgWorker.RunWorkerAsync();
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            gameOpen = m.OpenProcess("ULTRAKILL");

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

            if (devMode == true)
            {
                setHealthBtn.Enabled = true;
                freezeHealthBtn.Enabled = true;
                infDashChargeCheck.Enabled = true;
            }
            else
            {
                setHealthBtn.Enabled = false;
                freezeHealthBtn.Enabled = false;
                infDashChargeCheck.Enabled = false;
            }
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bgWorker.RunWorkerAsync();
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

        private void enableDevModeBtn_Click(object sender, EventArgs e)
        {
            if (DevModePassInput.Text == "")
            {
                devMode = !devMode;
            }
        }
    }
}
