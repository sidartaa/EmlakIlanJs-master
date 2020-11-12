using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Business.EmlakEngine
{
    public class EmlakKimdenEngine : BusinessEngineBase, IEmlakKimdenEngine
    {
        private readonly IEmlakKimden _emlakKimdenRepostory;
        public EmlakKimdenEngine(IEmlakKimden emlakKimden)
        {
            _emlakKimdenRepostory = emlakKimden;
        }
        public Task<List<EmlakKimdenResponse>> GetAllEmlakKimdenAsync()
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var emlakkimden = _emlakKimdenRepostory.GetAll();
                return Mapper.Map<List<EmlakKimdenResponse>>(await emlakkimden.ToListAsync());
            });
        }
    }
}
