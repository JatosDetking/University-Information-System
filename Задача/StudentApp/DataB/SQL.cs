using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;
using WindowsFormsApp1.StudentApp;

namespace WindowsFormsApp1
{
  static  class SQL
    {
       static string connectString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"C:\\Users\\sashk\\AppData\\Local\\Microsoft\\Microsoft SQL Server Local DB\\Instances\\MSSQLLocalDB.mdf\"; Integrated Security = True; Connect Timeout = 30";
       static public Account s;
       static public bool SM(string username, string password)
        {
                try
                {
                    using (SqlConnection myConnection = new SqlConnection(connectString))
                    {

                        string oString = "Select * from dbo.StudentList where Username=@fName";
                        SqlCommand oCmd = new SqlCommand(oString, myConnection);
                        oCmd.Parameters.AddWithValue("@fName", username);
                        myConnection.Open();
                        using (SqlDataReader oReader = oCmd.ExecuteReader())
                        {
                            while (oReader.Read())
                            {
                            int fn = Convert.ToInt32(oReader["FN"]);
                            string u = oReader["Username"].ToString();
                            string p = oReader["Password"].ToString().Replace(" ", "");
                            string t = oReader["Type"].ToString();
                            if (String.Equals(p, password))
                            {                            
                                s = new Student(u, p, t, fn);
                                return true;
                            }                                                         
                        }
                            myConnection.Close();
                        }
                    }
                }
                catch(SqlException e)
                {
                string ex = e.ToString();
                MessageBox.Show(ex);
                }
            MessageBox.Show("Аccount not found.");
            return false;

        }
           static public bool TM(string username, string password)
            {
            try
            {
                using (SqlConnection myConnection = new SqlConnection(connectString))
                {
                    string oString = "Select * from dbo.TeacherList where Username=@fName"; 
                    SqlCommand oCmd = new SqlCommand(oString, myConnection);
                    oCmd.Parameters.AddWithValue("@fname", username);
                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            string sn = oReader["subjectName"].ToString();
                          //  Subject m = new Subject(sn, null);
                            int tn = Convert.ToInt32(oReader["TN"]);
                            string u = oReader["Username"].ToString();
                            string p = oReader["Password"].ToString().Replace(" ", "");
                            string t = oReader["Type"].ToString();
                        if (String.Equals(p, password))
                        {
                                if (t == "L")
                                {
                           //         s = new Lector(u, p, t, tn, m);
                                }
                                else
                                {
                          //          s = new Asistant(u, p, t, tn, m);
                                }
                                return true;
                        }
                        else
                        {
                                MessageBox.Show("Аccount not found.");
                        }
                        }
                        myConnection.Close();
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return false;
        }
            static public void ES()
            {
                using (SqlConnection myConnection = new SqlConnection(connectString))
                {
                    string oString = "Select * from Employees where FirstName=@fName"; // ще се сменя
                    SqlCommand oCmd = new SqlCommand(oString, myConnection);
                 //   oCmd.Parameters.AddWithValue("@Fname", fName);
                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            string sn = oReader["subjectName"].ToString();
                        //    Subject m = new Subject(sn, null);
                            int tn = Convert.ToInt32(oReader["TN"]);
                            int fn = Convert.ToInt32(oReader["FN"]);
                            int id = Convert.ToInt32(oReader["ID"]);
                        }
                        myConnection.Close();
                    }
                }
            }
           static public void S()
            {
                using (SqlConnection myConnection = new SqlConnection(connectString))
                {
                    string oString = "Select * from Employees where FirstName=@fName"; // ще се сменя
                    SqlCommand oCmd = new SqlCommand(oString, myConnection);
                //    oCmd.Parameters.AddWithValue("@Fname", fName);
                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            string sn = oReader["subjectName"].ToString();
                            DateTime dt = Convert.ToDateTime(oReader["ExamDate"]);
                           // Subject m = new Subject(sn, null);

                        }
                        myConnection.Close();
                    }
                }
            }
          static  public void SuL()
            {
                using (SqlConnection myConnection = new SqlConnection(connectString))
                {
                    string oString = "Select * from Employees where FirstName=@fName"; // ще се сменя
                    SqlCommand oCmd = new SqlCommand(oString, myConnection);
         //           oCmd.Parameters.AddWithValue("@Fname", fName);
                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            int id = Convert.ToInt32(oReader["ID"]);
                            string sn = oReader["subjectName"].ToString();
                            int tn = Convert.ToInt32(oReader["TN"]);
                            int fn = Convert.ToInt32(oReader["FN"]);

                        }
                        myConnection.Close();
                    }
                }
            }
          static  public void SR()
            {
                using (SqlConnection myConnection = new SqlConnection(connectString))
                {
                    string oString = "Select * from Employees where FirstName=@fName"; // ще се сменя
                    SqlCommand oCmd = new SqlCommand(oString, myConnection);
           //         oCmd.Parameters.AddWithValue("@Fname", fName);
                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            int g = Convert.ToInt32(oReader["grade"]);
                            int id = Convert.ToInt32(oReader["ID"]);
                            int rid = Convert.ToInt32(oReader["RECID"]);

                        }
                        myConnection.Close();
                    }
                }
            }

        static public void RegisterS(string username, string password)
        {
            try
            {
                using (SqlConnection myConnection = new SqlConnection(connectString))
                {

                    string oString = "INSERT INTO dbo.StudentList (Username, Password, Type) VALUES (@Username, @Password, @Type)";
                    SqlCommand oCmd = new SqlCommand(oString, myConnection);
                    oCmd.Parameters.AddWithValue("@Username", username);
                    oCmd.Parameters.AddWithValue("@Password", password);
                    oCmd.Parameters.AddWithValue("@Type", "S");
                    myConnection.Open();
                    oCmd.ExecuteNonQuery();
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }

        }
        static public void RegisterT(string username, string password, string type , string subjectName)
        {
            try
            {
                using (SqlConnection myConnection = new SqlConnection(connectString))
                {

                    string oString = "INSERT INTO TeacherList (subjectName, Username, Password, Type) VALUES (@subjectName, @Username, @Password, @Type)";
                    SqlCommand oCmd = new SqlCommand(oString, myConnection);
                    oCmd.Parameters.AddWithValue("@Username", username);
                    oCmd.Parameters.AddWithValue("@Password", password);
                    oCmd.Parameters.AddWithValue("@Type", type);
                    oCmd.Parameters.AddWithValue("@subjectName", subjectName);
                    myConnection.Open();
                    oCmd.ExecuteNonQuery();
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }

        }
    }
} 

