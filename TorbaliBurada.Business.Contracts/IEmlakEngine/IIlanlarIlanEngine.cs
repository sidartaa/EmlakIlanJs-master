using System.Collections.Generic;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts;
using Torbali.Core.Common.Contracts.RequestMessages.Ilanlar;
using Torbali.Core.Common.Contracts.ResponseMessages;

namespace TorbaliBurada.Business.Contracts
{
    public  interface IIlanlarIlanEngine:IBusinessEngine
    {
        Task<IlanIlanlarResponse> GetAsync(int id);
        Task<List<IlanIlanlarResponse>> GetAllAsync(int skip, int take);
        Task<IlanIlanlarResponse> CreateAsync(EmlakIlanRequest request);
        Task<IlanUpdateResponse> UpdateAsync(UpdateIlanRequest request);
        Task DeleteAsync(int id);
        Task<List<IlanResponse>> SearchAsync(SerchRequest request);       
        Task<List<IlanIlanlarResponse>> GetAllIlanlarAsync(SerchRequest request);
        Task<List<TotalPageSearchResponse>> SearchTotalPageAsync(SerchRequest request);
        Task<TotalPageSearchResponse> TotalPageAsync(SerchRequest request);
        Task<TotalPageSearchResponse> SearchTotalPageEmlakAsync(SerchRequest request);
    }
}
