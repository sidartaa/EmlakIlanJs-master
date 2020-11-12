using System.Data.Entity;
using TorbaliBurada.Data;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
    public class EmlakKullanimDurumuRepostory : RepostoryBase<EmlakKullanimDurumu, int>, IEmlakKullanimDurumu
    {
        public EmlakKullanimDurumuRepostory(DbContext dbContext)
            : base(dbContext)
        {

        }
    }
}