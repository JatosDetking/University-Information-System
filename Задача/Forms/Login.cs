using System;
using System.Windows.Forms;
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1.Properties
{
    public partial class Login : Form
    { 
        public Login()
        {
            InitializeComponent();
               Type.Items.Add("S");
               Type.Items.Add("A");
               Type.Items.Add("L");    
        }
        private void Login_Click(object sender, EventArgs e)
        {        
            Account acc = LinQ.login(Username.Text, Password.Text, Type.Text);
            if (Username.Text != "" && Password.Text != "" && Type.Text != "")
            {
                if (acc != null)
                {                  
                    acc.newForm(this);                    
                }
                else if (acc == null)
                {
                    MessageBox.Show("Акаунтът не е намерен.");
                }
            }
            else
            {
                MessageBox.Show("Липсва информация.");
            }
        }
        private void Register_Click(object sender, EventArgs e)
        {
            Register a = new Register();
            this.Hide();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }
    }
}
