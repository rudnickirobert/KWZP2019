//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KWZP2019
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contract
    {
        public int IdContract { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<decimal> Salary { get; set; }
        public Nullable<int> IdEmployee { get; set; }
        public int IdPosition { get; set; }
        public Nullable<System.DateTime> HealTestDate { get; set; }
        public Nullable<System.DateTime> WorkplaceTrainingDate { get; set; }
    
        public virtual Position Position { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
