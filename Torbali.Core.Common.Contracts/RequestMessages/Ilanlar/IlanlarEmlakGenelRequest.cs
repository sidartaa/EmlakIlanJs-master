using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torbali.Core.Common.Contracts.RequestMessages.Ilanlar
{
    public class IlanlarEmlakGenelRequest
    {
        public int? EmlakIlanID { get; set; }
        public int? OdaSayisiID { get; set; }
        public int? BinaYasiID { get; set; }
        public int? BulunduguKatID { get; set; }
        public int? KatSayisiID { get; set; }
        public int? IsitmaID { get; set; }
        public int? BanyoSayisiID { get; set; }
        public int? KullanimDurumuID { get; set; }
        public int? SiteIcerisindeID { get; set; }
        public bool? Aidat { get; set; }
    }
}
