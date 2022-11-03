using System;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1.Forms
{
    public partial class MenuA : Form
    {
        public MenuA()
        {
            InitializeComponent();
        }

        private void EnterGrades_Click(object sender, EventArgs e)
        {
            EnterGrades a = new EnterGrades();
            this.Hide();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }
        private void ViewGrades_Click(object sender, EventArgs e)
        {
            ViewGradesT a = new ViewGradesT();
            this.Hide();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }
        private void ViewExamDate_Click(object sender, EventArgs e)
        {
            ViewExamDateT a = new ViewExamDateT();
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
        private void EnterZaverki_Click(object sender, EventArgs e)
        {
            EnterZaverki a = new EnterZaverki();
            this.Hide();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }
    }
}
