using System.Data.Entity;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
    public class EmlakTapuDurumuRepostory:RepostoryBase<EmlakTapuDurumu,int>,IEmlakTapuDurumu
    {
        public EmlakTapuDurumuRepostory(DbContext dbContext)
            :base(dbContext)
        {

        }
    }
}
