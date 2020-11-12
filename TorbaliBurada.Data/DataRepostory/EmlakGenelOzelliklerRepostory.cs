using System.Data.Entity;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
    public class EmlakGenelOzelliklerRepostory:RepostoryBase<EmlakGenelOzellikler,int>,IEmlakGenelOzellikler
    {
        public EmlakGenelOzelliklerRepostory(DbContext dbContext)
            :base(dbContext)
        {

        }
    }
}
