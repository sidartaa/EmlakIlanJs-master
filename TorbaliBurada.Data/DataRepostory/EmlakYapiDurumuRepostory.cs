using System.Data.Entity;
using TorbaliBurada.Data;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
   public class EmlakYapiDurumuRepostory:RepostoryBase<EmlakYapiDurumu,int>,IEmlakYapiDurumu
    {
        public EmlakYapiDurumuRepostory(DbContext dbContext)
            :base(dbContext)
        {

        }
    }
}
