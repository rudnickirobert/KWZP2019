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
    
    public partial class PlannedProductionEmployeeDetails
    {
        public int IdDetail { get; set; }
        public int IdProces { get; set; }
        public int IdEmployee { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
    
        public virtual Allocation Allocation { get; set; }
        public virtual PlannedProduction PlannedProduction { get; set; }
    }
}
