using System.Data.Entity;
using TorbaliBurada.Data;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
   public class EmlakLocationRepostory:RepostoryBase<EmlakLocation,int>,IEmlakLocation
    {
        public EmlakLocationRepostory(DbContext dbContext)
            :base(dbContext)
        {

        }
    }
}
