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
    
    public partial class Teachers
    {
        public Teachers()
        {
            this.TeacherSubject = new HashSet<TeacherSubject>();
        }
    
        public int TN { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
    
        public virtual ICollection<TeacherSubject> TeacherSubject { get; set; }
    }
}
