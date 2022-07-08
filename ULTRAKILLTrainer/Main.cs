using Memory;

namespace ULTRAKILLTrainer
{
    public partial class Main : Form
    {
        Mem m = new Mem();

        public Main()
        {
            InitializeComponent();
        }

        bool ProcOpen = false;


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
    }
}