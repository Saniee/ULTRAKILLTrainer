using System.Diagnostics;

namespace ULTRAKILLTrainer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GithubIssues_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe", "https://github.com/Saniee/ULTRAKILLTrainer/issues/new");
        }

        internal void Show(string errorCode)
        {
            ErrorCodeLabel.Text = errorCode;
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
