using System.Data.Entity;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
    public class EmlakTakasliRepostory:RepostoryBase<EmlakTakasli,int>,IEmlakTakasli
    {
        public EmlakTakasliRepostory(DbContext dbContext)
            :base(dbContext)
        {

        }
    }
}
