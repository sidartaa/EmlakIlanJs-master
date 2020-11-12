using System.Data.Entity;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
    public class EmlakCepheRepostory:RepostoryBase<EmlakCephe,int>,IEmlakCephe
    {
        public EmlakCepheRepostory(DbContext dbContext)
            :base(dbContext)
        {

        }
    }
}
