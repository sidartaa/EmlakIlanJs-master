using System.Data.Entity;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
    public class EmlakBulundugKatRepostory:RepostoryBase<EmlakBulunduguKat,int>,IEmlakBulunduguKat
    {
        public EmlakBulundugKatRepostory(DbContext dbContext)
            :base(dbContext)

        {

        }
    }
}
