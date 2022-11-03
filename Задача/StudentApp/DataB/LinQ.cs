using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;
using WindowsFormsApp1.StudentApp;
using SubjectRecord = WindowsFormsApp1.StudentApp.SubjectRecord;
using Subject = WindowsFormsApp1.StudentApp.Subject;

namespace WindowsFormsApp1.Forms
{
    static class LinQ
    {
        static DBContext db = new DBContext();
        private static Account account;
        private static Subject subject;
        static public Account getAccount()
        {
            return account;
        }
        static public Subject getSubject()
        {
            return subject;
        }
        static public Subject OutPutSubject(string name)
        {
            var sub = db.Subjects.SingleOrDefault(o => o.SubjectName == name);
            if (sub != null)
            {
                if (sub.SubjectName == name)
                {
                    subject = new Subject(sub.SubjectName, sub.Type);
                    subject.setED(sub.ExamDate);
                    Lector l;
                    Asistant a;
                    Student s;
                    SubjectRecord sr = new SubjectRecord();
                    List<SubjectRecord> lsr = new List<SubjectRecord>();
                    int g;
                    int gu;
                    string z;
                    string zu;
                    foreach (var ts in db.TeacherSubject)
                    {
                        if (sub.SID == ts.SID)
                        {
                            foreach (var t in db.Teachers)
                            {
                                if (ts.TN == t.TN)
                                {
                                    if (t.Type == "L")
                                    {
                                        l = new Lector(t.Username, t.Password, t.Type, t.TN);
                                        subject.setL(l);
                                    }
                                    else
                                    {
                                        a = new Asistant(t.Username, t.Password, t.Type, t.TN);
                                        subject.setA(a);
                                    }
                                }
                            }
                        }
                    }
                    foreach (var ss in db.StudentSubject)
                    {
                        if (sub.SID == ss.SID)
                        {
                            foreach (var student in db.Students)
                            {
                                if (ss.FN == student.FN)
                                {
                                    s = new Student(student.Username, student.Password, "S", student.FN);
                                    sr = new SubjectRecord(s);
                                }
                            }
                            foreach (var gr in db.GradesRecord)
                            {
                                if (ss.ID == gr.ID)
                                {
                                    if (gr.Type == "L")
                                    {
                                        g = gr.Grade;
                                        sr.setG(g);
                                    }
                                    else if (gr.Type == "U")
                                    {
                                        gu = gr.Grade;
                                        sr.setGU(gu);
                                    }
                                }
                            }
                            foreach (var zr in db.ZaverkiRecord)
                            {
                                if (ss.ID == zr.ID)
                                {
                                    if (zr.Type == "L")
                                    {
                                        z = zr.Zaverka;
                                        sr.setZ(z);
                                    }
                                    else if (zr.Type == "U")
                                    {
                                        zu = zr.Zaverka;
                                        sr.setZU(zu);
                                    }
                                }
                            }
                            lsr.Add(sr);
                            subject.setSubjectRecords(lsr);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Грешно име на предмет.");
                }                
            }
            return subject;
        }
        static public Account login(string username, string password, string type)
        {
            if (type == "L")
            {
                foreach (var teacher in db.Teachers)
                {
                    if (username == teacher.Username && password == teacher.Password && type == teacher.Type)
                    {
                        account = new Lector(username, password, type, teacher.TN);
                        return new Lector(username, password, type, teacher.TN);
                    }
                }
            }
            else if (type == "A")
            {
                foreach (var teacher in db.Teachers)
                {
                    if (username == teacher.Username && password == teacher.Password && type == teacher.Type)
                    {
                        account = new Asistant(username, password, type, teacher.TN);
                        return new Asistant(username, password, type, teacher.TN);
                    }
                }
            }
            else if (type == "S")
            {
                foreach (var student in db.Students)
                {
                    if (username == student.Username && password == student.Password)
                    {
                        account = new Student(username, password, type, student.FN);
                        autoSubjectAdd();
                        return new Student(username, password, type, student.FN);
                    }
                }
            }
            return null;
        }
        static public void register(string username, string password, string type)
        {
            if (type == "S")
            {
                db.Students.Add(new Students
                {
                    Username = username,
                    Password = password,
                });
                db.SaveChanges();
            }
            else if (type == "L" || type == "A")
            {
                db.Teachers.Add(new Teachers
                {
                    Username = username,
                    Password = password,
                    Type = type,
                });
                db.SaveChanges();
            }
        }
        static public List<string> teacherSubjectName()
        {
            List<string> a = new List<string>();
            foreach (var ts in db.TeacherSubject)
            {
                if (ts.TN == ((Teacher) account).getTn())
                {
                    foreach (var s in db.Subjects)
                    {
                        if (ts.SID == s.SID)
                        {
                            a.Add(s.SubjectName);
                        }
                    }
                }
            }
            return a;
        }
        static public List<string> StudentSubjectName()
        {
            List<string> a = new List<string>();
            foreach (var ts in db.StudentSubject)
            {
                if (ts.FN == ((Student)account).getFN())
                {
                    foreach (var s in db.Subjects)
                    {
                        if (ts.SID == s.SID)
                        {
                            a.Add(s.SubjectName);
                        }
                    }
                }
            }
            return a;
        }
        static public List<string> StudentSubjectName2()
        {
            List<string> a = new List<string>();
            List<string> b = StudentSubjectName();
            foreach (var s in db.Subjects)
            {
                if (!b.Contains(s.SubjectName))
                {
                    a.Add(s.SubjectName);
                }
            }
            return a;
        }
        static public List<string> AsistantName()
        {
            List<string> a = new List<string>();
            foreach (var ts in db.Teachers)
            {
                if (ts.Type == "A")
                {
                    a.Add(ts.Username);
                }
            }
            return a;
        }
        static private Asistant getAsistant(string name)
        {
            foreach (var asistan in db.Teachers)
            {
                if (asistan.Username == name)
                {
                    return (new Asistant(asistan.Username, asistan.Password, asistan.Type, asistan.TN));
                }
            }
            return null;
        }
        static private int SubjectID(string sn)
        {
            foreach (var sub in db.Subjects)
            {
                if (sub.SubjectName == sn)
                {
                    return sub.SID;
                }
            }
            return -1;
        }
        static private int StudentSubjectID(int name)
        {
            foreach (var ss in db.StudentSubject)
            {
                foreach (var sub in db.Subjects)
                {
                    if (ss.FN == ((Student)account).getFN() && ss.SID == name)
                    {
                        return ss.ID;
                    }
                }
            }
            return -1;
        }
        static public void RegisterSubject(string subjectN, string type, string asistantN)
        {
            Asistant a = getAsistant(asistantN);
            bool c = false;
            foreach (var sub in db.Subjects)
            {
                if (sub.SubjectName == subjectN)
                {
                    c = true;
                }
            }
            if (c == false)
            {
                db.Subjects.Add(new Subjects
                {
                    SubjectName = subjectN,
                    Type = type,
                    ExamDate = new DateTime(2000, 01, 01, 00, 00, 00)
                });
                db.SaveChanges();
                int b = SubjectID(subjectN);
                db.TeacherSubject.Add(new TeacherSubject
                {
                    TN = a.getTn(),
                    SID = b
                });
                db.TeacherSubject.Add(new TeacherSubject
                {
                    TN = ((Lector)getAccount()).getTn(),
                    SID = b
                });
                MessageBox.Show("Готово.");
                db.SaveChanges();

            }
            else
            {
                MessageBox.Show("Предметат е зает.");
            }
        }
        static public void AddSubject(string name)
        {
            bool c = false;
            int a = SubjectID(name);
            foreach (var ss in db.StudentSubject)
            {
                if (ss.SID == a && ss.FN == ((Student)account).getFN())
                {
                    c = true;
                }
            }
            if (c == false)
            {
                db.StudentSubject.Add(new StudentSubject
                {
                    FN = ((Student)account).getFN(),
                    SID = a
                });
                db.SaveChanges();
                int b = StudentSubjectID(a);
                db.GradesRecord.Add(new GradesRecord
                {
                    ID = b,
                    Grade = 0,
                    Type = "L"
                });
                db.GradesRecord.Add(new GradesRecord
                {
                    ID = b,
                    Grade = 0,
                    Type = "U"
                });
                db.ZaverkiRecord.Add(new ZaverkiRecord
                {
                    ID = b,
                    Zaverka = "F",
                    Type = "L"
                });
                db.ZaverkiRecord.Add(new ZaverkiRecord
                {
                    ID = b,
                    Zaverka = "F",
                    Type = "U"
                });
                db.SaveChanges();
                MessageBox.Show("Готово.");
            }
            else
            {
                MessageBox.Show("Вече е направено.");
            }
        }
        static public void addExamD(string name, DateTime ex)
        {
            var a = db.Subjects.Where(o => o.SubjectName == name);
            foreach (var i in a)
            {
                i.ExamDate = ex;
            }
            db.SaveChanges();
            MessageBox.Show("Готово.");
        }
        static public void addGrade(int grade, int fn, string name)
        {
            var a = db.Subjects.Where(o => o.SubjectName == name);
            var b = db.StudentSubject.Where(o => o.FN == fn);
            foreach (var s in a)
            {
                foreach (var ss in b)
                {
                    if (s.SID == ss.SID)
                    {
                        var c = db.GradesRecord.Where(o => o.ID == ss.ID);
                        foreach (var gr in c)
                        {
                            if (LinQ.getAccount().getType() == "L" && gr.Type == "L")
                            {
                                gr.Grade = grade;
                            }
                            else if (LinQ.getAccount().getType() == "A" && gr.Type == "U")
                            {
                                gr.Grade = grade;
                            }
                        }
                    }
                }
            }
            MessageBox.Show("Готово.");
            db.SaveChanges();
        }
        static public void addZaverki(int fn, string name)
        {
            var a = db.Subjects.Where(o => o.SubjectName == name);
            var b = db.StudentSubject.Where(o => o.FN == fn);
            foreach (var s in a)
            {
                foreach (var ss in b)
                {
                    if (s.SID == ss.SID)
                    {
                        var c = db.ZaverkiRecord.Where(o => o.ID == ss.ID);
                        foreach (var zr in c)
                        {
                            if (LinQ.getAccount().getType() == "L")
                            {
                                zr.Zaverka = "T";
                            }
                            else if (LinQ.getAccount().getType() == "A" && zr.Type == "U")
                            {
                                zr.Zaverka = "T";
                            }
                        }
                    }
                }
            }
            MessageBox.Show("Готово.");
            db.SaveChanges();
        }
        static private void autoSubjectAdd()
        {

        }
    }
}


