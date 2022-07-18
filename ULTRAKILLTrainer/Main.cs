using Memory;
using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ULTRAKILLTrainer
{
    public partial class Main : Form
    {
        Mem m = new Mem();
        private string errorCode = "0";
        private string problemCode = "";

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        static extern bool VirtualFreeEx(IntPtr hProcess, UIntPtr lpAddress, UIntPtr dwSize, uint dwFreeType);

        public bool DeAllocRegion(UIntPtr codecavebase, IntPtr openedHandle)
        {
            // maybe check if codecavebase is uintptr.zero and openedhandle is intptr.zero etc

            return VirtualFreeEx(openedHandle, codecavebase, (UIntPtr)0, 0x00008000);
        }

        public Main()
        {
            InitializeComponent();
        }

        private Form1 errorForm;

        bool ProcOpen = false;
        private UIntPtr codeCaveDamage;
        long aobDamageScan;

        string playerBase = "mono-2.0-bdwgc.dll+00494A90,DE8,0,F8,20";
        string wepCharges = "mono-2.0-bdwgc.dll+00494A90,E50,28,A0,250,20";
        string coinRecharge = ",38";
        string walkSpeed = ",1A0";
        string jumpForce = ",1A4";
        string playerHealth = ",20C";
        string nailgunAmmo = ",4C";
        string railgunCharge = ",5C";
        string boostRecharge = ",288";
        string fallingBool = ",1B1";

        private void Main_Shown(object sender, EventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }

        private void BGWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            ProcOpen = m.OpenProcess("ULTRAKILL");

            Thread.Sleep(100);
            BGWorker.ReportProgress(0);
        }

        private void BGWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
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

        private void BGWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }

        private void InfHealth_CheckedChanged(object sender, EventArgs e)
        {
            if (InfHealth.Checked)
            {
                m.FreezeValue(playerBase + playerHealth, "int", "1000");
            }
            else
            {
                m.UnfreezeValue(playerBase + playerHealth);
            }
        }

        private void InfDash_CheckedChanged(object sender, EventArgs e)
        {
            if (InfDash.Checked)
            {
                m.FreezeValue(playerBase + boostRecharge, "float", "300");
            }
            else
            {
                m.UnfreezeValue(playerBase + boostRecharge);
            }
        }

        private void InfRailgun_CheckedChanged(object sender, EventArgs e)
        {
            if (InfRailgun.Checked)
            {
                m.FreezeValue(wepCharges + railgunCharge, "float", "5");
            }
            else
            {
                m.UnfreezeValue(wepCharges + railgunCharge);
            }
        }

        private void InfNailgun_CheckedChanged(object sender, EventArgs e)
        {
            if (InfNailgun.Checked)
            {
                m.FreezeValue(wepCharges + nailgunAmmo, "float", "100");
            }
            else
            {
                m.UnfreezeValue(wepCharges + nailgunAmmo);
            }
        }

        private async void OneShot_CheckedChanged(object sender, EventArgs e)
        {
            errorCode = "404 PNTR";
            problemCode = "One Shot Enemies Feature";
            if (OneShot.Checked)
            {
                byte[] newBytes =
                {
                    0xC7, 0x45, 0x30, 0x00, 0x00, 0x7A, 0x44
                };
                aobDamageScan = (await m.AoBScan("F3 0F 11 6D 30 49 8B 47", false, true)).FirstOrDefault();
                if (aobDamageScan == 0)
                {
                    Debug.WriteLine("Scan Unsuccsesful.");
                    errorForm = new Form1();
                    errorForm.Show(errorCode, problemCode);
                    OneShot.Enabled = false;
                    OneShot.Checked = false;
                } 
                else
                {
                    Debug.WriteLine("Scan Succses! Addres found: " + aobDamageScan.ToString("X"));
                    codeCaveDamage = m.CreateCodeCave(aobDamageScan.ToString("X"), newBytes, 5, 1000);
                }
            }
            else
            {
                DeAllocRegion(codeCaveDamage, m.mProc.Handle);
                Debug.WriteLine("Deallocated Region " + aobDamageScan.ToString("X"));
                m.WriteMemory(aobDamageScan.ToString("X"), "bytes", "F3 0F 11 6D 30");
                Debug.WriteLine("Wrote original assembly into the scan address.");
            }
        }

        private void InfJump_CheckedChanged(object sender, EventArgs e)
        {
            if (InfJump.Checked)
            {
                m.FreezeValue(playerBase + fallingBool, "int", "0");
            }
            else
            {
                m.UnfreezeValue(playerBase + fallingBool);
            }
        }

        private void walkSpeedBar_Scroll(object sender, EventArgs e)
        {
            m.WriteMemory(playerBase + walkSpeed, "float", walkSpeedBar.Value.ToString());
        }

        private void walkSpeedBar_ValueChanged(object sender, EventArgs e)
        {
            m.WriteMemory(playerBase + walkSpeed, "float", walkSpeedBar.Value.ToString());
        }

        private void jumpForceBar_ValueChanged(object sender, EventArgs e)
        {
            m.WriteMemory(playerBase + jumpForce, "float", jumpForceBar.Value.ToString());
        }

        private void InfCoins_CheckedChanged(object sender, EventArgs e)
        {
            if (InfCoins.Checked)
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