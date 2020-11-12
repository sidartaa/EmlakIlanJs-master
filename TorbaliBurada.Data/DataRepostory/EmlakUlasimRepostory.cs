using System.Data.Entity;
using TorbaliBurada.Data;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
   public class EmlakUlasimRepostory:RepostoryBase<EmlakUlasim,int>,IEmlakUlasim
    {
        public EmlakUlasimRepostory(DbContext dbContext)
            :base(dbContext)
        {

        }
    }
}
