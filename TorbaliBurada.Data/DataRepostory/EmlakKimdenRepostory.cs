using System.Data.Entity;
using TorbaliBurada.Data;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
   public class EmlakKimdenRepostory:RepostoryBase<EmlakKimden,int>,IEmlakKimden
    {
        public EmlakKimdenRepostory(DbContext dbContext)
            :base(dbContext)
        {

        }
    }
}
