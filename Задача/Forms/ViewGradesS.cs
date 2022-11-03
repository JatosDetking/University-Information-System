using System;
using System.Windows.Forms;
using WindowsFormsApp1.Forms;
using WindowsFormsApp1.StudentApp;

namespace WindowsFormsApp1
{
    public partial class ViewGradesS : Form
    {
        public ViewGradesS()
        {
            InitializeComponent();
            foreach (var i in LinQ.StudentSubjectName())
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
        private void Search_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((Student)LinQ.getAccount()).ViewGrade(LinQ.OutPutSubject(Subject.Text)));
        }
    }
}
