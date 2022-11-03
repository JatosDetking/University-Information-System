using System;
using System.Windows.Forms;
using WindowsFormsApp1.Forms;
using WindowsFormsApp1.StudentApp;

namespace WindowsFormsApp1
{
    public partial class EnterExamDate : Form
    {
        public EnterExamDate()
        {
            InitializeComponent();                   
                foreach (var i in LinQ.teacherSubjectName())
                {
                    Subject.Items.Add(i);
                }
           
            ExDate.Format = DateTimePickerFormat.Custom;
            ExDate.CustomFormat = "MM/dd/yyyy hh:mm:ss";
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            
            ((Lector)LinQ.getAccount()).ЕnterExamData(LinQ.OutPutSubject(Subject.Text), ExDate.Value);
        }
        private void Back_Click(object sender, EventArgs e)
        {
            MenuT a = new MenuT();
            this.Hide();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }
    }
}
