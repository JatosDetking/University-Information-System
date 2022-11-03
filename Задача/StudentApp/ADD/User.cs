using System.Collections.Generic;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1.StudentApp
{
    static class User
    {
         private static List<Account> account = new List<Account>();
         
          public static Account login(string username, string password)
          {
              int j = 0;

              foreach (var i in account)
              {
                  if (username.Equals(account[j].getUsername()) && password.Equals(account[j].getPassword()))
                  {
                      //break;
                      return account[j];
                  }
                  j++;
              }
              return  new Student("0","0","0",-1);
          }
          public static void registerS(string username, string password, string type, int fn)
          {
              Account a = new Student(username , password, type, fn);
              account.Add(a);
          }
          public static void registerT(string username, string password, string type,int tn, Subject subject)
          {
              if (type.Equals("A"))
              {
                //  Account a = new Asistant(username, password, type, tn, subject);
               //   account.Add(a);
              }
              else if (type.Equals("L"))
              {
               //   Account a = new Lector(username, password, type, tn , subject);
               //account.Add(a);
              }
          }
    }
}
