using System;
using System.Windows.Forms;
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1.StudentApp
{
    class Lector: Teacher
    {
        public Lector(string u, string p, string t, int tn) : base(u, p, t, tn)
        {
            this.username = u;
            this.password = p;
            this.type = t;
            this.tN = tn;
        }
        public Lector()
        {
          
        }
        public override void EnterGrades(Subject s,int fn, int grade)
        {
            if (GetSubjectRecord(fn, s) != null)
            {
                GetSubjectRecord(fn, s).setG(grade);
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
                GetSubjectRecord(fn, s).setZ("Y");
                GetSubjectRecord(fn, s).setZU("Y");
                LinQ.addZaverki(fn, s.getN());
            }
            else
            {
                MessageBox.Show("Няма такъв студент.");
            }    
        }
        public void ЕnterExamData(Subject s, DateTime ed)
        {
            LinQ.addExamD(s.getN(), ed);
            s.setED(ed);
        }
        public string ViewZaverki(Subject s, int fn)
        {
            if (GetSubjectRecord(fn, s) != null)
            {
                string a = GetSubjectRecord(fn, s).getZ();
                string b = GetSubjectRecord(fn, s).getZU();
                if (a == "T")
                {
                    a = $"Има завека на лекции по {s.getN()}.";
                }
                else if (a == "F")
                {
                    a = $"Няма завека на лекции по {s.getN()}.";
                }
                if (b == "T")
                {
                    b = $"Има завека на упражнение по {s.getN()}.";
                }
                else if (b == "F")
                {
                    b = $"Няма завека на упражнение по {s.getN()}.";
                }
                return $"{a}\n{b}";
            }
            return $"Няма такъв студент.";
        }
        public void RegisteSubject(string subjectN, string type, string asistantN)
        {
            LinQ.RegisterSubject(subjectN,type,asistantN);
        }
        public override void newForm(Form priviast)
        {
            MenuT a = new MenuT();
            priviast.Hide();
            a.Closed += (s, args) => priviast.Close();
            a.Show();
        }
    }
}
