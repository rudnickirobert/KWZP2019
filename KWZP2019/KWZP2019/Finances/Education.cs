//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KWZP2019.Finances
{
    using System;
    using System.Collections.Generic;
    
    public partial class Education
    {
        public int IdEducation { get; set; }
        public Nullable<int> IdEmployee { get; set; }
        public Nullable<int> IdEducationLevel { get; set; }
        public Nullable<System.DateTime> GraduationDate { get; set; }
    
        public virtual EducationLevel EducationLevel { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
