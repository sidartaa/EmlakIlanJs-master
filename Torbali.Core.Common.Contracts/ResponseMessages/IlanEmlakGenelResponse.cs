using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorbaliBurada.Data.CodeFirst.Entity;

namespace Torbali.Core.Common.Contracts.ResponseMessages
{
    public class IlanEmlakGenelResponse
    {
        public int? Id { get; set; }
       // public int? EmlakIlanID { get; set; }
        public string OdaSayisiID { get; set; }
        // public int? BinaYasiID { get; set; }
        public string BulunduguKatID { get; set; }
        //public int? KatSayisiID { get; set; }
        public string IsitmaID { get; set; }
        // public int? BanyoSayisiID { get; set; }
        //public int? KullanimDurumuID { get; set; }
        //  public int? SiteIcerisindeID { get; set; }
        // public bool? Aidat { get; set; }
        public string EmlakDurumu { get; set; }
        public string TapuDurumu { get; set; }
        public string EmlakKullanimAmaci { get; set; }       
        public string EmlakImarDurumu { get; set; }
        public string IlanImarTapuDurumu { get; set; }
        public IlanIlanlarResponse ilan { get; set; }
        public List<IlanIcOzelliklerResponse> ilanIcOzellikler { get; set; }
        public List<IlanDisOzelliklerResponse> ilanDisOzellikler { get; set; }
        public List<IlanResimlerResponse> ilanResimler { get; set; }
        public List<EmlakKategoilerResponse> ilanKategoriler { get; set; }

    }
}
