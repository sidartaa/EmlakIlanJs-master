using System.Data.Entity;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
    public class EmlakDisOzelliklerRepostory:RepostoryBase<EmlakDisOzellikler,int>,IEmlakDisOzellikler
    {
        public EmlakDisOzelliklerRepostory(DbContext dbContext)
            :base(dbContext)
        {

        }
    }
}
