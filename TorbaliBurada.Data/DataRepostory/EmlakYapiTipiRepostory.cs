using System.Data.Entity;
using TorbaliBurada.Data;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
   public class EmlakYapiTipiRepostory:RepostoryBase<EmlakYapiTipi,int>,IEmlakYapiTipi
    { 
        public EmlakYapiTipiRepostory(DbContext dbContext)
            :base(dbContext)
        {
                
        }
    }
}
