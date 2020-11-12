using System.Data.Entity;
using TorbaliBurada.Data;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
   public class EmakKonutTipiRepostory:RepostoryBase<EmlakKonutTipi,int>,IEmlakKonutTipi
    {
        public EmakKonutTipiRepostory(DbContext dbContext)
            :base(dbContext)
        {

        }
    }
}
