using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Business.EmlakEngine
{
    public class EmlakManzaraEngine : BusinessEngineBase, IEmlakManzaraEngine
    {
       private readonly IEmlakManzara _emlakManzaraRepostory;
        public EmlakManzaraEngine(IEmlakManzara emlakManzaraRepostory)
        {
            _emlakManzaraRepostory = emlakManzaraRepostory;
        }
        public Task<List<EmlakManzaraResponse>> GetAllEmlakManzaraResponseAsync()
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var emlakmanzara = _emlakManzaraRepostory.GetAll();
                return Mapper.Map<List<EmlakManzaraResponse>>(await emlakmanzara.ToListAsync());
            });
        }
    }
}
