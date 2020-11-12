using System.Data.Entity;
using TorbaliBurada.Data;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
   public class EmlakOdaSayisiRepostory:RepostoryBase<EmlakOdaSayisi,int>,IEmlakOdaSayisi
    {
        public EmlakOdaSayisiRepostory(DbContext dbContext)
            :base(dbContext)
        {

        }
    }
}
