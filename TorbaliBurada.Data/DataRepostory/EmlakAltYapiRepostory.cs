using System.Data.Entity;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
    public class EmlakAltYapiRepostory:RepostoryBase<EmlakAltyapi,int>,IEmlakAltyapi
    {
        public EmlakAltYapiRepostory(DbContext dbContext)
            :base(dbContext)
        {

        }
    }
}
