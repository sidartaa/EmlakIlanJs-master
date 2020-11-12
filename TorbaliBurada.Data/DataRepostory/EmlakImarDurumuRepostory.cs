using System.Data.Entity;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
    public class EmlakImarDurumuRepostory:RepostoryBase<EmlakImarDurumu,int>,IEmlakImarDurumu
    {
        public EmlakImarDurumuRepostory(DbContext dbContext)
            :base(dbContext)
        {

        }
    }
}
