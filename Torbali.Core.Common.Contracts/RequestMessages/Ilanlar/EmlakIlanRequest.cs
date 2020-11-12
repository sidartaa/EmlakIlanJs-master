using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torbali.Core.Common.Contracts.RequestMessages.Ilanlar
{
   public class EmlakIlanRequest
    {
            //SatilikId: '',
            //IlanTuru: '',
            //id: '',
            //SemtId: '',
            //MahalleId: '',
            //IlanKimden: '',
            //Sahibi: '',
            //CepTelefonu: '',
            //Baslik: '',
            //Aciklama: '',
            //Fiyat: '',
            //Metrekare: '',            
            //Private: '',
            //TakasliID: '',
            //TakasTuru: '',
            //Pafta: '',
            //Parsel: '',
            //Ada: '',
            //KonutTipi: '',
            //OdaSayisi: '',
            //BulunduguKat: '',
            //Isitma: '',
            //IcOzellikler: '',
            //DisOzelliker: '',
            //EmlakKullanimAmaci: '',
            //EmlakImarDurumu: '',
            //EmlakTapuDurumu: '',
            //UserName:''
        
        // İlan Kategori
        public int id { get; set; }
        public int IlanTuru { get; set; }
        public int IlanKimden { get; set; }
        public int SatilikId { get; set; }
        public int SemtId { get; set; }
        public int MahalleId { get; set; }
        //İlanlar İlan
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string Fiyat { get; set; }
        public string MetreKare { get; set; }
        public int TakasliID { get; set; }
        public string TakasTuru { get; set; }

        public string Sahibi { get; set; }
        public string CepTelefonu { get; set; }
        public string Pafta { get; set; }
        public string Parsel { get; set; }
        public string Ada { get; set; }
        public string Private { get; set; }
        public string UserName { get; set; }

        public int OdaSayisi { get; set; }
        public int BulunduguKat { get; set; }
        public int Isitma { get; set; }
        public string IcOzellikler { get; set; }
        public string DisOzellikler { get; set; }
        public int KonutTipi { get; set; }
       
        public int EmlakImarDurumu { get; set; }
        public int EmlakTapuDurumu { get; set; }
        public int EmlakKullanimAmaci { get; set; }
        public string IletisimTelefonu { get; set; }

    }
}
