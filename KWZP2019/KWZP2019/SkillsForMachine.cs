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
    
    public partial class SkillsForMachine
    {
        public int IdSkill { get; set; }
        public Nullable<int> IdMachine { get; set; }
        public int IdPosition { get; set; }
    
        public virtual Machine Machine { get; set; }
        public virtual Position Position { get; set; }
    }
}
