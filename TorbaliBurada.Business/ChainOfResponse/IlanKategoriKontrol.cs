using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorbaliBurada.Business.ChainOfResponse
{
    public class IlanKategoriKontrol : SearchEmlakBase
    {
        public override void ExecuteProcess(SerchChanRequest _search)
        {
            if (base.sonuc)//bir önceki adımdan geçiyorsa
            {
                try
                {
                    _search.request.id = Convert.ToInt32(_search.request.id);
                    if (_search.request.id != 0)
                        base.sonuc = true;
                    else
                        base.sonuc = false;
                    base.ListKategori = _search.ListKategori;
                    base.total = _search.total;
                    base.request = _search.request;
                    base._emlakKategoriler = _search._emlakKategoriler;
                    base._ilanResimler = _search._ilanResimler;
                    base._ilanTipOzellikler = _search._ilanTipOzellikler;
                    base.pageSize = _search.pageSize;

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
