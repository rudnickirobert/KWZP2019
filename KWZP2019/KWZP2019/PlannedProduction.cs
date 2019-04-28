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
    
    public partial class PlannedProduction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PlannedProduction()
        {
            this.PlannedProductionEmployeeDetails = new HashSet<PlannedProductionEmployeeDetail>();
            this.ProductionProcess = new HashSet<ProductionProcess>();
        }
    
        public int IdPlan { get; set; }
        public int IdDetail { get; set; }
        public int IdMachine { get; set; }
        public Nullable<System.DateTime> PlannedStartd { get; set; }
        public Nullable<System.DateTime> PlannedEndd { get; set; }
        public Nullable<bool> Inproduction { get; set; }
    
        public virtual OrderDetail OrderDetail { get; set; }
        public virtual OrderDetail OrderDetail1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlannedProductionEmployeeDetail> PlannedProductionEmployeeDetails { get; set; }
        public virtual Maintenance Maintenance { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductionProcess> ProductionProcess { get; set; }
    }
}
