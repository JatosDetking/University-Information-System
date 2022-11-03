namespace WindowsFormsApp1.StudentApp
{
    class SubjectRecord
    {
        private Student student;
        private int grades = 0;
        private int gradesU = 0;
        private string zaverka = "F";
        private string zaverkaU = "F";

        public SubjectRecord(Student s)
        {
            this.student = s;
        }
        public SubjectRecord()
        {         
        }
        public Student getStudent()
        {
            return this.student;
        }
        public void setStudent(Student s)
        {
            this.student = s;
        }
        public int getG()
        {
            return this.grades;
        }
        public void setG(int a)
        {
            this.grades = a;
        }
        public int getGU()
        {
            return this.gradesU;
        }
        public void setGU(int a)
        {
            this.gradesU = a;
        }
        public string getZ()
        {
            return this.zaverka;
        }
        public void setZ(string a)
        {
            this.zaverka = a;
        }
        public string getZU()
        {
            return this.zaverkaU;
        }
        public void setZU(string a)
        {
            this.zaverkaU = a;
        }
    }
}
