//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlogTemp.Data.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bio
    {
        public int ID { get; set; }
        public int User_ID { get; set; }
        public string Bio1 { get; set; }
    
        public virtual User User { get; set; }
    }
}
