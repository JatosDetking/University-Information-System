using System;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1.StudentApp
{
     abstract class Teacher: Account
    {
        protected int tN;

        protected Teacher(string u, string p, string t, int tn) : base(u, p, t)
        {
            this.username = u;
            this.password = p;
            this.type = t;
            this.tN = tn;
        }
        protected Teacher()
        {
          
        }
        public int getTn()
        {
            return this.tN;
        }
        protected SubjectRecord GetSubjectRecord(int fn, Subject s)
        {
            if (s != null)
            {
                if (type == "L")
                {
                    var student = s.getL();
                    if (student != null)
                    {
                        if (s.getL().getTn() == tN)
                        {
                            return s.getSubjectRecord(fn);
                        }
                    }
                }
                else if (type == "A")
                {
                    var student = s.getA();
                    if (student != null)
                    {
                        if (s.getA().getTn() == tN)
                        {
                            return s.getSubjectRecord(fn);
                        }
                    }
                }
            }
            return null;
        }
        public string ViewExamDate(Subject s)
        {
            string r = s.getED().ToString();
            DateTime n = new DateTime(2000, 01, 01, 00, 00, 00);
            if (s.getED() == n)
            {
                return "Датата не е излязла.";
            }

            return $"Изпита по {s.getN()} е на {r}.";
        }
        public  string ViewGrade(Subject s , int fn)
        {
                if (GetSubjectRecord(fn, s) != null)
                {
                int a = GetSubjectRecord(fn, s).getG();
                int b = GetSubjectRecord(fn, s).getGU();
                string c = null;
                string d = null;
                if (a == 0)
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
                return $"Няма такъв студент.";               
        }

        public abstract void EnterGrades(Subject s, int fn, int grade);

        public abstract void EnterZaverka(Subject s, int fn);

    }
}
