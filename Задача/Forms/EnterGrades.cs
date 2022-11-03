using System;
using System.Windows.Forms;
using WindowsFormsApp1.Forms;
using WindowsFormsApp1.StudentApp;

namespace WindowsFormsApp1
{
    public partial class EnterGrades : Form
    {
        public EnterGrades()
        {
            InitializeComponent();
            Grade.Items.Add("2");
            Grade.Items.Add("3");
            Grade.Items.Add("4");
            Grade.Items.Add("5");
            Grade.Items.Add("6");
            foreach (var i in LinQ.teacherSubjectName())
            {
                Subject.Items.Add(i);
            }
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            int p = 0;
            if (int.TryParse(FN.Text, out p))
            {
                ((Teacher)LinQ.getAccount()).EnterGrades(LinQ.OutPutSubject(Subject.Text), Convert.ToInt32(FN.Text), Convert.ToInt32(Grade.Text));
            }
            else
            {
                FN.Clear();
                MessageBox.Show("Невалиден факултетен номер.");
            }        
        }
        private void Back_Click(object sender, EventArgs e)
        {
            LinQ.getAccount().newForm(this);
        }
    }
}

