using System.Collections.Generic;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts;
using Torbali.Core.Common.Contracts.RequestMessages.Musteriler;
using Torbali.Core.Common.Contracts.ResponseMessages;

namespace TorbaliBurada.Business.Contracts.IEmlakEngine
{
    public interface IMusteriListEngine : IBusinessEngine
    {
        Task<MusterilerResponse> CreateAsync(MusterilerListInsertRequest request);
        Task<MusterilerListResponse> GetAllMusterilerAsync(SerchMusteriRequest request);
    }
}
