//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TorbaliBurada.Data.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class IlanKimden
    {
        public int IlanKimdenID { get; set; }
        public Nullable<int> EmlakIlanID { get; set; }
        public Nullable<int> KimdemID { get; set; }
    
        public virtual EmlakKimden EmlakKimden { get; set; }
        public virtual IlanIlanlar IlanIlanlar { get; set; }
    }
}