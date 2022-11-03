using System;
using System.Windows.Forms;
using WindowsFormsApp1.Forms;
using WindowsFormsApp1.StudentApp;

namespace WindowsFormsApp1
{
    public partial class ViewExamDateT : Form
    {
        public ViewExamDateT()
        {
            InitializeComponent();
            foreach (var i in LinQ.teacherSubjectName())
            {
                Subject.Items.Add(i);
            }
        }
        private void Search_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((Teacher)LinQ.getAccount()).ViewExamDate(LinQ.OutPutSubject(Subject.Text)));
        }
        private void Back_Click(object sender, EventArgs e)
        {
            LinQ.getAccount().newForm(this);
        }
    }
}
