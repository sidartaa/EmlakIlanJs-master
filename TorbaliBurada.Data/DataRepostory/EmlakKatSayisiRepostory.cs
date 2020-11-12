using System.Data.Entity;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
    public class EmlakKatSayisiRepostory:RepostoryBase<EmlakKatSayisi,int>,IEmlakKatSayisi
    {
        public EmlakKatSayisiRepostory(DbContext dbContext)
            :base(dbContext)
        {

        }
    }
}
