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
    
    public partial class PartOrderRequest
    {
        public int IdPartOrderRequest { get; set; }
        public int IdPartOrder { get; set; }
        public int IdPartRequest { get; set; }
    
        public virtual PartRequest PartRequest { get; set; }
    }
}