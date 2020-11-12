using System.Data.Entity;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
    public class IlanIlanlarRepostory: RepostoryBase<IlanIlanlar, int>, IIlanIlanlar
    {
        public IlanIlanlarRepostory(DbContext dbContext)
            :base(dbContext)
        {

        }
    }
}
