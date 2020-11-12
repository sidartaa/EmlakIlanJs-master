using System.Collections.Generic;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts;
using Torbali.Core.Common.Contracts.RequestMessages.IlanResimler;
using Torbali.Core.Common.Contracts.ResponseMessages;

namespace TorbaliBurada.Business.Contracts.IEmlakEngine
{
    public interface IIlanResimlerEngine:IBusinessEngine
    {
        Task<IlanResimlerResponse> CreateAsync(IlanResimlerRequest categoryCreateRequest);
        Task DeleteAsync(int id);
        Task<IlanResimlerResponse> GetAsync(int id);
        IlanResimlerResponse CreateeAsync(IlanResimlerRequest request);
        Task<IlanResimlerResponse> GetResimAsync(IlanResimlerRequeste request);
        Task<List<IlanResimlerResponse>> GetListResimAsync(IlanResimlerRequeste request);
    }
}
