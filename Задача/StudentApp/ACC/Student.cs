using System;
using System.Windows.Forms;
using WindowsFormsApp1.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1.StudentApp
{
    class Student : Account
    {
        private int fn = 0;

        public Student(string u, string p, string t, int f) : base(u, p, t)
        {
            this.username = u;
            this.password = p;
            this.type = t;
            this.fn = f;
        }
        public int getFN()
        {
            return this.fn;
        }
        public string viewExamDate(Subject s)
        {
            string r = s.getED().ToString();
            DateTime n = new DateTime(2000, 01, 01, 00, 00, 00);
            if (s.getED() == n)
            {
                return "Датата не е излязла.";
            }
 
            return $"Изпита по {s.getN()} е на {r}.";
        }    
        public string viewZaverki(Subject s)
        {
             string a = s.getSubjectRecord(fn).getZ();
             string b = s.getSubjectRecord(fn).getZU();
            if(a == "T")
            {
                a = $"Имаш завека на лекции по {s.getN()}.";
            }
            else if(a == "F")
            {
                a = $"Нямаш завека на лекции по {s.getN()}.";
            }
            if (b == "T")
            {
                b = $"Имаш завека на лекции по {s.getN()}.";
            }
            else if (b == "F")
            {
                b = $"Нямаш завека на лекции по {s.getN()}.";
            }
            return $"{a}\n{b}";
        }
        public string ViewGrade(Subject s)
        {         
            int a = s.getSubjectRecord(fn).getG();
            int b = s.getSubjectRecord(fn).getGU();
            string c = null;
            string d = null;
            if(a == 0)
            {
                c = $"Няма оценка на лекции по {s.getN()}.";
            }
            else
            {
                c = $"Оценката ти на лекции по {s.getN()} е {a}.";
            }
            if (b == 0)
            {
                d = $"Няма оценка на упражнението по {s.getN()}.";
            }
            else
            {
                d = $"Оценката ти на упражнението по {s.getN()} е {b}.";
            }

            return $"{c}\n{d}";
        }
        public void addSubject(string a)
        {
            LinQ.AddSubject(a);
        }
        public override void newForm(Form priviast)
        {
            MenuS a = new MenuS();
            priviast.Hide();
            a.Closed += (s, args) => priviast.Close();
            a.Show();
        }
    }
}
