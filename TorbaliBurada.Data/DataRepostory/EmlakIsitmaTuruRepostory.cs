using System.Data.Entity;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
    public class EmlakIsitmaTuruRepostory:RepostoryBase<EmlakIsitmaTuru,int>,IEmlakIsitmaTuru
    {
        public EmlakIsitmaTuruRepostory(DbContext dbContext)
            :base(dbContext)
        {

        }
    }
}
