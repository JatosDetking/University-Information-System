using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.StudentApp
{
    class Subject
    {
        private string name;
        private string type;
        private Lector lector;
        private Asistant asistant;
        private List<SubjectRecord> subjectRecords = new List<SubjectRecord>();
        private DateTime ExamData = new DateTime(2000, 01, 01, 00, 00, 00);

        public Subject(string n, string t)
        {
            this.name = n;
            this.type = t;
        }
        public string getN()
        {
            return this.name;
        }
        public string getT()
        {
            return this.type;
        }
        public DateTime getED()
        {
            return this.ExamData;
        }
        public void setED(DateTime ed)
        {
            this.ExamData = ed;
        }
        public Lector getL()
        {
            return this.lector;
        }
        public void setL(Lector l)
        {
            this.lector = l;
        }
        public Asistant getA()
        {
            return this.asistant;
        }
        public void setA(Asistant a)
        {
            this.asistant = a;
        }
        public List<SubjectRecord> getSubjectRecords()
        {
            return this.subjectRecords;
        }
        public void setSubjectRecords(List<SubjectRecord> s)
        {
            this.subjectRecords = s;
        }
        public SubjectRecord getSubjectRecord(int fn)
        {
            foreach (var sr in subjectRecords)
            {
                if (sr.getStudent().getFN() == fn)
                {
                    return sr;
                }
            }
            return null;
        }
    }
}
