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
    
    public partial class IlanAdresler
    {
        public int Id { get; set; }
        public Nullable<int> EmlakIlanID { get; set; }
        public Nullable<int> LocationID { get; set; }
        public string Adres { get; set; }
    
        public virtual EmlakLocation EmlakLocation { get; set; }
        public virtual IlanIlanlar IlanIlanlar { get; set; }
    }
}
