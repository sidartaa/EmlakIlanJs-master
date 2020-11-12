using System.Data.Entity;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
    public class EmlakSiteIcerisindeRepostory:RepostoryBase<EmlakSiteIcerisinde,int>,IEmlakSiteIcerisinde
    {
        public EmlakSiteIcerisindeRepostory(DbContext dbContext)
            :base(dbContext)
        {

        }
    }
}
