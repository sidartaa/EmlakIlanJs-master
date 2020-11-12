using System.Data.Entity;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
    public class MusteriListRepostory:RepostoryBase<MusteriList,int>,IMusteriList
    {
        public MusteriListRepostory(DbContext dbContext)
            :base(dbContext)
        {

        }
        
    }
}
