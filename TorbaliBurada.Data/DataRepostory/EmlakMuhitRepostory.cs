using System.Data.Entity;
using TorbaliBurada.Data;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
   public class EmlakMuhitRepostory:RepostoryBase<EmlakMuhit,int>,IEmlakMuhit
    {
        public EmlakMuhitRepostory(DbContext dbContext)
            :base(dbContext)
        {

        }
    }
}
