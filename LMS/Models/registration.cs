//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class registration
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public Nullable<int> course_id { get; set; }
        public string prn { get; set; }
        public string mobile_no { get; set; }
        public string address { get; set; }
    
        public virtual course course { get; set; }
        public virtual registration registration1 { get; set; }
        public virtual registration registration2 { get; set; }
    }
}
