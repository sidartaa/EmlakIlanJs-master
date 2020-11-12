using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts.RequestMessages.Ilanlar;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Business.ChainOfResponse
{
    public abstract class SearchEmlakBase
    {
        public SerchRequest request { get; set; }
        public List<KategoriSearch> ListKategori { get; set; }
        public TotalPageSearchResponse total;
        public List<IlanIlanlar> ilanIlanlar { get; set; }
        public IEmlakKategoriler _emlakKategoriler { get; set; }
        public IIlanResimler _ilanResimler { get; set; }
        public IIlanKonutTipiOzellikler _ilanTipOzellikler { get; set; }
        public IIlanKullanimAmaci _ilanIsyeriTipi { get; set; }

        public int pageSize = 2;
        public bool sonuc;
        protected SearchEmlakBase _nextOperation;
        public abstract void ExecuteProcess(SerchChanRequest _search);
        public void Execute(SerchChanRequest search)
        {
            ExecuteProcess(search);
            if (this._nextOperation != null)
            {
                this._nextOperation.sonuc = this.sonuc;
                this._nextOperation.request=this.request;
                this._nextOperation.ListKategori = this.ListKategori;
                this._nextOperation.total = this.total;
                this._nextOperation._emlakKategoriler = this._emlakKategoriler;
                this._nextOperation._ilanResimler = this._ilanResimler;
                this._nextOperation._ilanTipOzellikler = this._ilanTipOzellikler;
                this._nextOperation.ilanIlanlar = this.ilanIlanlar;
                this._nextOperation.pageSize = this.pageSize;
                this._nextOperation._ilanIsyeriTipi = this._ilanIsyeriTipi;
                this._nextOperation.Execute(search);
            }
        }
        public void setNext(SearchEmlakBase operation)
        {
            this._nextOperation = operation;
        }
    }
}
