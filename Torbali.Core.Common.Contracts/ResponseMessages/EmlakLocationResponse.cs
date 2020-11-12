using System;

namespace Torbali.Core.Common.Contracts.ResponseMessages
{
    public class EmlakLocationResponse
    {
        //public int Id { get; set; }
        public string LocationName { get; set; }
        //public Nullable<int> ParentID { get; set; }
        //public Nullable<int> PlakaID { get; set; }
        //public string Logo { get; set; }
        //public string Aciklama { get; set; }
        public string Message { get; set; }
        public bool Sonuc { get; set; }
    }
}
