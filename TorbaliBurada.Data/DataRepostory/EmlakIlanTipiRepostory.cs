using System.Data.Entity;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
    public class EmlakIlanTipiRepostory:RepostoryBase<EmlakIlanTipi,int>,IEmlakIlanTipi
    {
        public EmlakIlanTipiRepostory(DbContext dbContext)
            :base(dbContext)
        {

        }
    }
}
