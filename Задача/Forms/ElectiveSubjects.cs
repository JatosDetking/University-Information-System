using System;
using System.Windows.Forms;
using WindowsFormsApp1.Forms;
using WindowsFormsApp1.StudentApp;

namespace WindowsFormsApp1
{
    public partial class ElectiveSubjects : Form
    {
        public ElectiveSubjects()
        {
            InitializeComponent();
            foreach (var i in LinQ.StudentSubjectName2())
            {
                Subject.Items.Add(i);
            }
        }
        private void Back_Click(object sender, EventArgs e)
        {
            MenuS a = new MenuS();
            this.Hide();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }
        private void Add_Click(object sender, EventArgs e)
        {
            ((Student)LinQ.getAccount()).addSubject(Subject.Text);
        }
    }
}
