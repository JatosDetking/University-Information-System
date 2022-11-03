using System;
using System.Windows.Forms;
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1.StudentApp
{
    class Asistant :Teacher
    {
        public Asistant(string u, string p, string t, int tn) : base(u, p, t, tn)
        {
            this.username = u;
            this.password = p;
            this.type = t;
            this.tN = tn;
        }
        public Asistant()
        {
          
        }
        public override void EnterGrades(Subject s, int fn, int grade)
        {
            if (GetSubjectRecord(fn, s) != null )
            {
                GetSubjectRecord(fn, s).setGU(grade);
                LinQ.addGrade(grade, fn, s.getN());
            }
            else
            {
                MessageBox.Show("Няма такъв студент.");
            }          
        }
        public override void EnterZaverka(Subject s, int fn)
        {
            if (GetSubjectRecord(fn, s) != null)
            {
                GetSubjectRecord(fn, s).setZU("Y");
                LinQ.addZaverki(fn, s.getN());
            }
            else
            {
                MessageBox.Show("Няма такъв студент.");
            }
        }
        public override void newForm(Form priviast)
        {
            MenuA a = new MenuA();
            priviast.Hide();
            a.Closed += (s, args) => priviast.Close();
            a.Show();
        }
    }
}
