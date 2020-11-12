using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Business.EmlakEngine
{
    public class ArsaGenelOzellikleriEngine : BusinessEngineBase, IArsaGenelOzellikleriEngine
    {
        private readonly IArsaGenelOzelikleri _arsaGenelOzellikleriRepostory;
        public ArsaGenelOzellikleriEngine(IArsaGenelOzelikleri arsaGenelOzellikleriRepostory)
        {
            _arsaGenelOzellikleriRepostory = arsaGenelOzellikleriRepostory;
        }
        public Task<List<ArsaGenelOzellikleriResponse>> GetAllArsaGenelOzellikleriAsync()
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var binayasi = _arsaGenelOzellikleriRepostory.GetAll();
                return Mapper.Map<List<ArsaGenelOzellikleriResponse>>(await binayasi.ToListAsync());
            });
        }
    }
}
