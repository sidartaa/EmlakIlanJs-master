using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Business.EmlakEngine
{
  public  class EmlakBulunduguKatEngine : BusinessEngineBase, IEmlakBulunduguKatEngine
    {
        private readonly IEmlakBulunduguKat _emlakBulunduguKatRepostory;
        public EmlakBulunduguKatEngine(IEmlakBulunduguKat emlakBulunduguKatRepostory)
        {
            _emlakBulunduguKatRepostory = emlakBulunduguKatRepostory;
        }
        public Task<List<EmlakBulunduguKatResponse>> GetAllEmlakBulunduguKatAsync()
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var emlakbulundugukat = _emlakBulunduguKatRepostory.GetAll();
                return Mapper.Map<List<EmlakBulunduguKatResponse>>(await emlakbulundugukat.ToListAsync());
            });
        }
    }
}
