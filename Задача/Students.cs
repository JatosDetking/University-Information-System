//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Students
    {
        public Students()
        {
            this.StudentSubject = new HashSet<StudentSubject>();
        }
    
        public int FN { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    
        public virtual ICollection<StudentSubject> StudentSubject { get; set; }
    }
}
