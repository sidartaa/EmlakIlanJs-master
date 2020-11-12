using System.Data.Entity;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
    public class IlanlarEmlakGenelRepostory:RepostoryBase<IlanlarEmlakGenel,int>, IIlanlarEmlakGenel
    {
        public IlanlarEmlakGenelRepostory(DbContext dbContext)
            :base(dbContext)
        {

        }
    }
}
