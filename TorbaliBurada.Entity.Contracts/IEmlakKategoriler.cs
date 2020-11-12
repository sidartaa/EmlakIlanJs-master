using System.Linq;
using TorbaliBurada.Data.Contracts;
using TorbaliBurada.Data.CodeFirst.Entity;

namespace TorbaliBurada.Entity.Contracts
{
    public interface IEmlakKategoriler : IRepositoryBase<EmlakKategoriler, int>
    {
      //  IQueryable<EmlakKategoriler> GetParentId(int id);
    }
}
