using System;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class MenuS : Form
    {
        public MenuS()
        {
            InitializeComponent();
        }

        private void ViewGrades_Click(object sender, EventArgs e)
        {
            ViewGradesS a = new ViewGradesS();
            this.Hide();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }
        private void ViewZaverki_Click(object sender, EventArgs e)
        {
            ViewZaverkiS a = new ViewZaverkiS();
            this.Hide();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }
        private void ViewExamDate_Click(object sender, EventArgs e)
        {
            ViewExamDateS a = new ViewExamDateS();
            this.Hide();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }
        private void ElectiveSubjects_Click(object sender, EventArgs e)
        {
            ElectiveSubjects a = new ElectiveSubjects();
            this.Hide();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }
        private void Logout_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            this.Hide();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }
    }
}
