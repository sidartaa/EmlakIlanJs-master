using System.Data.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
    public class IlanResimlerRepostory:RepostoryBase<CodeFirst.Entity.IlanResimler, int>, IIlanResimler
    {
        public IlanResimlerRepostory(DbContext dbContext)
            : base(dbContext)
        {

        }
    }
}
