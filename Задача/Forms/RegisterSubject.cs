using System;
using System.Windows.Forms;
using WindowsFormsApp1.StudentApp;

namespace WindowsFormsApp1.Forms
{
    public partial class RegisterSubject : Form
    {
        public RegisterSubject()
        {
            InitializeComponent();
            SybjectType.Items.Add("M");
            SybjectType.Items.Add("E");
            foreach (var i in LinQ.AsistantName())
            {
                Asistant.Items.Add(i);
            }
        }

        private void Register_Click(object sender, EventArgs e)
        {
            ((Lector)LinQ.getAccount()).RegisteSubject(SubjectName.Text, SybjectType.Text, Asistant.Text);
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
