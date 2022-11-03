using System;
using System.Windows.Forms;
using WindowsFormsApp1.Forms;
using WindowsFormsApp1.StudentApp;

namespace WindowsFormsApp1
{
    public partial class ViewGradesT : Form
    {
        public ViewGradesT()
        {
            InitializeComponent();
            foreach (var i in LinQ.teacherSubjectName())
            {
                Subject.Items.Add(i);
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            LinQ.getAccount().newForm(this);
        }
        private void Search_Click(object sender, EventArgs e)
        {          
            int p = 0;
            if (int.TryParse(FN.Text, out p))
            {
                MessageBox.Show(((Teacher)LinQ.getAccount()).ViewGrade(LinQ.OutPutSubject(Subject.Text), Convert.ToInt32(FN.Text)));
            }
            else
            {
                FN.Clear();
                MessageBox.Show("Невалиден факултетен номер.");
            }
        }
    }
}
