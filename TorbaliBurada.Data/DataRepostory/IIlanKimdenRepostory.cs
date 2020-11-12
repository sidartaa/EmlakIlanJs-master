using System.Data.Entity;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
    public class IIlanKimdenRepostory : RepostoryBase<IlanKimden, int>, IIlanKimden
    {
        public IIlanKimdenRepostory(DbContext dbContext)
            : base(dbContext)
        {

        }
    }
}
