using System.Data.Entity;
using TorbaliBurada.Data;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
   public class EmlakManzaraRepostory:RepostoryBase<EmlakManzara,int>,IEmlakManzara
    {
        public EmlakManzaraRepostory(DbContext dbContext)
            :base(dbContext)
        {

        }
    }
}
