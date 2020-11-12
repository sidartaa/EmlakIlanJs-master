using System.Data.Entity;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
    public class IlanImarTapuDurumuRepostory:RepostoryBase<IlanImarTapuDurumu,int>, IIlanImarTapuDurumu
    {
        public IlanImarTapuDurumuRepostory(DbContext dbContext)
            :base(dbContext)
        {

        }
    }
}
