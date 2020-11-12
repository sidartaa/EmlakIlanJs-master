using System.Data.Entity;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
    public  class ArsaGenelOzellikleriRepostory: RepostoryBase<ArsaGenelOzelikleri, int>, IArsaGenelOzelikleri
    {
        public ArsaGenelOzellikleriRepostory(DbContext dbContext)
            :base(dbContext)
        {

        }
    }
}
