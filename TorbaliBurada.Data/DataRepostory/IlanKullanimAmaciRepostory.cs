using System.Data.Entity;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
    public class IlanKullanimAmaciRepostory:RepostoryBase<IlanKullanimAmaci,int>, IIlanKullanimAmaci
    {
        public IlanKullanimAmaciRepostory(DbContext dbContext)
            :base(dbContext)
        {

        }
    }
}
