using System.Threading.Tasks;
using Torbali.Core.Common.Contracts;
using Torbali.Core.Common.Contracts.RequestMessages.IlanEmlakGenel;
using Torbali.Core.Common.Contracts.RequestMessages.Ilanlar;
using Torbali.Core.Common.Contracts.ResponseMessages;

namespace TorbaliBurada.Business.Contracts.IEmlakEngine
{
    public interface IIlanlarEmlakGenelEngine:IBusinessEngine
    {
        Task<IlanEmlakGenelResponse> CreateAsync(IlanlarEmlakGenelRequest request);
        Task<IlanEmlakGenelResponse> UpdateAsync(IlanlarEmlakGenelRequest request);
        Task DeleteAsync(int id);
        Task<IlanEmlakGenelResponse> GetAsync(IlanEmlakGenelRequest id);
    }
}
