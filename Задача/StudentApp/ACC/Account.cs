using System.Windows.Forms;

namespace WindowsFormsApp1.Properties
{
    public abstract class Account
    {
        protected string username;
        protected string password;
        protected string type;

        protected Account(string u, string p, string t)
        {
            this.username = u;
            this.password = p;
            this.type = t;
        }
        protected Account()
        {

        }
        public string getUsername()
        {
            return this.username;
        }
        public string getPassword()
        {
            return this.password;
        }
        public string getType()
        {
            return this.type;
        }
        public abstract void newForm(Form priviast);
    }
}
