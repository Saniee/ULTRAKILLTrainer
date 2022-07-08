using Memory;
using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ULTRAKILLTrainer
{
    public partial class Main : Form
    {
        Mem m = new Mem();

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

        bool ProcOpen = false;
        private UIntPtr codeCaveDamage;
        long aobDamageScan;

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
                m.FreezeValue("mono-2.0-bdwgc.dll+00494A90,DE8,0,F8,20,20C", "int", "1000");
            }
            else
            {
                m.UnfreezeValue("mono-2.0-bdwgc.dll+00494A90,DE8,0,F8,20,20C");
            }
        }

        private void InfDash_CheckedChanged(object sender, EventArgs e)
        {
            if (InfDash.Checked)
            {
                m.FreezeValue("mono-2.0-bdwgc.dll+00494A90,DE8,0,F8,20,288", "float", "300");
            }
            else
            {
                m.UnfreezeValue("mono-2.0-bdwgc.dll+00494A90,DE8,0,F8,20,288");
            }
        }

        private void InfRailgun_CheckedChanged(object sender, EventArgs e)
        {
            if (InfRailgun.Checked)
            {
                m.FreezeValue("UnityPlayer.dll+01815FA0,A90,180,D0,48,F0,0,5C", "float", "5");
            }
            else
            {
                m.UnfreezeValue("UnityPlayer.dll+01815FA0,A90,180,D0,48,F0,0,5C");
            }
        }

        private void InfNailgun_CheckedChanged(object sender, EventArgs e)
        {
            if (InfNailgun.Checked)
            {
                m.FreezeValue("UnityPlayer.dll+01815FA0,A90,180,D0,48,F0,0,4C", "float", "100");
            }
            else
            {
                m.UnfreezeValue("UnityPlayer.dll+01815FA0,A90,180,D0,48,F0,0,4C");
            }
        }

        private async void OneShot_CheckedChanged(object sender, EventArgs e)
        {
            if (OneShot.Checked)
            {
                byte[] newBytes =
                {
                    0xC7, 0x45, 0x30, 0x00, 0x00, 0x7A, 0x44,
                };
                aobDamageScan = (await m.AoBScan("F3 0F 11 6D 30 49 8B 47")).FirstOrDefault();
                codeCaveDamage = m.CreateCodeCave(aobDamageScan.ToString("X"), newBytes, 5, 2048);
            }
            else
            {
                DeAllocRegion(codeCaveDamage, m.mProc.Handle);
                m.WriteMemory(aobDamageScan.ToString("X"), "bytes", "F3 0F 11 6D 30");
            }
        }

        private void InfJump_CheckedChanged(object sender, EventArgs e)
        {
            if (!InfJump.Checked)
            {
                m.FreezeValue("mono-2.0-bdwgc.dll+004A6418,280,540,F0,0,1B0", "int", "0");
            }
            else
            {
                m.UnfreezeValue("mono-2.0-bdwgc.dll+004A6418,280,540,F0,0,1B0");
            }
        }
    }
}