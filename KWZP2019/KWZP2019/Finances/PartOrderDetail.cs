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
    
    public partial class PartOrderDetail
    {
        public int IdPartOrderDetail { get; set; }
        public int IdPartOrder { get; set; }
        public int IdPart { get; set; }
        public int Quantity { get; set; }
    
        public virtual Part Part { get; set; }
        public virtual PartOrder PartOrder { get; set; }
    }
}
