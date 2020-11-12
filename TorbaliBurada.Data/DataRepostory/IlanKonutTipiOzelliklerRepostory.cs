using System.Data.Entity;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
    public class IlanKonutTipiOzelliklerRepostory:RepostoryBase<IlanKonutTipiOzellikler,int>, IIlanKonutTipiOzellikler
    {
        public IlanKonutTipiOzelliklerRepostory(DbContext dbContext)
            : base(dbContext)
        {

        }
    }
}
