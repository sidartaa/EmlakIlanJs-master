using System.Data.Entity;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
    public class IEmlakBinaYasiRepostory: RepostoryBase<EmlakBinaYasi, int>, IEmlakBinaYasi
    {
        public IEmlakBinaYasiRepostory(DbContext dbContext)
            :base(dbContext)
        {

        }
    }
}
