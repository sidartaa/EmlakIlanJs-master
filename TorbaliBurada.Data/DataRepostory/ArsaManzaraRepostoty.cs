using System.Data.Entity;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
    public class ArsaManzaraRepostoty: RepostoryBase<ArsaManzara,int>,IArsaManzara
    {
        public ArsaManzaraRepostoty(DbContext dbContext)
            :base(dbContext)
        {

        }
    }
}
