using System;
using System.Windows.Forms;
using WindowsFormsApp1.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            Type.Items.Add("S");
            Type.Items.Add("A");
            Type.Items.Add("L");
        }
        private void Register_Click(object sender, EventArgs e)
        {
            Account acc = LinQ.login(Username.Text, Password.Text, Type.Text);
            if(acc == null)
            {
                if (Username.Text != "" && Password.Text != "" && Type.Text != "")
                {
                    LinQ.register(Username.Text, Password.Text, Type.Text);
                    MessageBox.Show("Готово.");
                    Login b = new Login();
                    this.Hide();
                    b.Closed += (s, args) => this.Close();
                    b.Show();                   
                }
                else
                {
                    MessageBox.Show("Липсва информация.");
                }
            }
            else
            {
                MessageBox.Show("Вече съществива такъв акаунт.");
            }             
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            this.Hide();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }
    }
}
