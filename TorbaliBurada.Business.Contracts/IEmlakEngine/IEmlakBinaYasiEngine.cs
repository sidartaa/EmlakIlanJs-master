using System.Collections.Generic;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts;
using Torbali.Core.Common.Contracts.RequestMessages;
using Torbali.Core.Common.Contracts.ResponseMessages;

namespace TorbaliBurada.Business.Contracts
{
    public interface IEmlakBinaYasiEngine : IBusinessEngine
    {
        Task<EmlakBinaYasiResponse> GetAsync(int id);
        Task<List<EmlakBinaYasiResponse>> GetAllAsync(int skip, int take);
        Task<EmlakBinaYasiResponse> CreateAsync(BinaYasiRequest request);
        Task<EmlakBinaYasiResponse> UpdateAsync(BinaYasiUpdateRequest request);
        Task DeleteAsync(int id);
        Task<List<EmlakBinaYasiResponse>> SearchAsync(BinaYasiSearchRequest request);
        Task<List<EmlakBinaYasiResponse>> GetAllBinaYasiAsync();
    }
}
