using System.Data.Entity;
using TorbaliBurada.Data;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
   public class EmlakKullanimAmaciRepostory:RepostoryBase<EmlakKullanimAmaci,int>,IEmlakKullanimAmaci
    {
        public EmlakKullanimAmaciRepostory(DbContext dbContext)
            :base(dbContext)
        {

        }
    }
}
