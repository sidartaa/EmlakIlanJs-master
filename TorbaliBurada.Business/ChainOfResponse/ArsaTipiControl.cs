using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorbaliBurada.Business.ChainOfResponse
{
    public class ArsaTipiControl : SearchEmlakBase
    {
        public override void ExecuteProcess(SerchChanRequest _search)
        {
            if (base.sonuc)
            {
                base.sonuc = true;
            }
        }
    }
}
