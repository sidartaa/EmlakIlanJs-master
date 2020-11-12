using System.Data.Entity;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
    public class ArsaKonumRepostory:RepostoryBase<ArsaKonumu,int>, IArsaKonumu
    {
        public ArsaKonumRepostory(DbContext dbContext)
            :base(dbContext)
        {

        }
    }
}
