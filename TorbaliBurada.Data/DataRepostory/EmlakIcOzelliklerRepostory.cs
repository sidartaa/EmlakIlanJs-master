using System.Data.Entity;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
    public class EmlakIcOzelliklerRepostory:RepostoryBase<EmlakIcOzellikler,int>,IEmlakIcOzellikler
    {
        public EmlakIcOzelliklerRepostory(DbContext dbContext)
            :base(dbContext)
        {

        }
    }
}
