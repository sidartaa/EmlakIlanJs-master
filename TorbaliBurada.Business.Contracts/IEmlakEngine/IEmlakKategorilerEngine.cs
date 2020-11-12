using System.Collections.Generic;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts;
using Torbali.Core.Common.Contracts.ResponseMessages;

namespace TorbaliBurada.Business.Contracts
{
    public interface IEmlakKategorilerEngine:IBusinessEngine
    {
        Task<List<EmlakKategoilerResponse>> GetAllEmlakKategorilerAsync();
        Task<List<EmlakKategoilerResponse>> GetParentIdKategorilerAsync(int id);
    }
}
