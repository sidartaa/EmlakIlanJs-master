using System.Data.Entity;
using TorbaliBurada.Data;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
 public class EmlakKonutTipiRepostory:RepostoryBase<EmlakKonutTipi,int>,IEmlakKonutTipi
    {
        public EmlakKonutTipiRepostory(DbContext dbContext)
            :base(dbContext)
        {

        }
    }
}
