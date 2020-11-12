using System.Data.Entity;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
    public class EmlakBanyoSayisiRepostory:RepostoryBase<EmlakBanyoSayisi,int>,IEmlakBanyoSayisi
    {
        public EmlakBanyoSayisiRepostory(DbContext dbContext)
            :base(dbContext)
        {

        }
    }
}
