using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace ULTRAKILLTrainer_Cheats
{
    public partial class Main : Form
    {
        Mem m = new Mem();

        public Main()
        {
            InitializeComponent();
        }
        
        // Game Open Label Bool
        bool ProcOpen = false;

        // Player Info Stuff
        int healthNum;
        float hardDmgNum;
        bool railgunReady;
        float walkSpeedNum;
        float jumpForceNum;

        // Base Addresses
        string playerBase = "UnityPlayer.dll+01773900,CC8,0,370,148,20,D8";
        string wepCharges = "UnityPlayer.dll+01770340,70,B0,60,C0,F8,20";

        // Player Offsets
        string playerHealth = ",21C";
        string boostRecharge = ",288";
        string fallingBool = ",1C1";
        string wallJumps = ",210";
        string hardDmg = ",220";
        string walkSpeed = ",1B0";
        string jumpForce = ",1B4";
        
        // Wep Charges Offsets
        string nailgunAmmo = ",54";
        string railgunCharge = ",64";
        string coinRecharge = ",40";

        private void Main_Shown(object sender, EventArgs e)
        {
            BGWorker.RunWorkerAsync();
            BGPlayerStatCheck.RunWorkerAsync();
        }

        private void BGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ProcOpen = m.OpenProcess("ULTRAKILL");

            Thread.Sleep(100);
            BGWorker.ReportProgress(0);
        }

        private void BGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (ProcOpen)
            {
                ProcOpenLabel.ForeColor = Color.Green;
                ProcOpenLabel.Text = "Yes";
            }
            else
            {
                ProcOpenLabel.ForeColor = Color.Red;
                ProcOpenLabel.Text = "N/A";
                return; // do not continue if process is not available/open
            }
        }

        private void BGPlayerStatCheck_DoWork(object sender, DoWorkEventArgs e)
        {
            healthNum = m.ReadInt(playerBase + playerHealth);
            hardDmgNum = m.ReadFloat(playerBase + hardDmg);
            walkSpeedNum = m.ReadFloat(playerBase + walkSpeed);
            jumpForceNum = m.ReadFloat(playerBase + jumpForce);
            if (m.ReadFloat(wepCharges + railgunCharge) == 5)
            {
                railgunReady = true;
            }
            else
            {
                railgunReady = false;
            }

            Thread.Sleep(100);
            BGPlayerStatCheck.ReportProgress(0);
        }

        private void BGPlayerStatCheck_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pHealth.Text = "Health: " + healthNum;
            hDmg.Text = "Hard Damage: " + hardDmgNum;
            railgunInfo.Text = "Railgun Ready?: " + railgunReady;
            walkSpeedInfo.Text = "Walk Speed: " + walkSpeedNum;
            jumpForceInfo.Text = "Jump Foce: " + jumpForceNum;
        }

        private void BGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }

        private void BGPlayerStatCheck_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BGPlayerStatCheck.RunWorkerAsync();
        }

        private void infHealth_CheckedChanged(object sender, EventArgs e)
        {
            if (infHealth.Checked)
            {
                m.FreezeValue(playerBase + playerHealth, "int", "1000");
            }
            else
            {
                m.UnfreezeValue(playerBase + playerHealth);
                m.WriteMemory(playerBase + playerHealth, "int", "100");
            }
        }

        private void noHardDmg_CheckedChanged(object sender, EventArgs e)
        {
            if (noHardDmg.Checked)
            {
                m.FreezeValue(playerBase + hardDmg, "float", "0");
            }
            else
            {
                m.UnfreezeValue(playerBase + hardDmg);
            }
        }

        private void infDash_CheckedChanged(object sender, EventArgs e)
        {
            if (infDash.Checked)
            {
                m.FreezeValue(playerBase + boostRecharge, "float", "300");
            }
            else
            {
                m.UnfreezeValue(playerBase + boostRecharge);
            }
        }

        private void infJump_CheckedChanged(object sender, EventArgs e)
        {
            if (infJump.Checked)
            {
                m.FreezeValue(playerBase + fallingBool, "int", "0");
            }
            else
            {
                m.UnfreezeValue(playerBase + fallingBool);
            }
        }

        private void infWallJump_CheckedChanged(object sender, EventArgs e)
        {
            if (infWallJump.Checked)
            {
                m.FreezeValue(playerBase + wallJumps, "int", "0");
            }
            else
            {
                m.UnfreezeValue(playerBase + wallJumps);
            }
        }

        private void walkSpeedBar_ValueChanged(object sender, EventArgs e)
        {
            m.WriteMemory(playerBase + walkSpeed, "float", walkSpeedBar.Value.ToString());
        }

        private void jumpForceBar_ValueChanged(object sender, EventArgs e)
        {
            m.WriteMemory(playerBase + jumpForce, "float", jumpForceBar.Value.ToString());
        }

        private void infRailgun_CheckedChanged(object sender, EventArgs e)
        {
            if (infRailgun.Checked)
            {
                m.FreezeValue(wepCharges + railgunCharge, "float", "5");
            }
            else
            {
                m.UnfreezeValue(wepCharges + railgunCharge);
            }
        }

        private void infNailgun_CheckedChanged(object sender, EventArgs e)
        {
            if (infNailgun.Checked)
            {
                m.FreezeValue(wepCharges + nailgunAmmo, "float", "100");
            }
            else
            {
                m.UnfreezeValue(wepCharges + nailgunAmmo);
            }
        }

        private void infCoins_CheckedChanged(object sender, EventArgs e)
        {
            if (infCoins.Checked)
            {
                m.FreezeValue(wepCharges + coinRecharge, "float", "400");
            }
            else
            {
                m.UnfreezeValue(wepCharges + coinRecharge);
            }
        }
    }
}
