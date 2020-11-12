using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Business.EmlakEngine
{
    public class EmlakKatSayisiEngine : BusinessEngineBase, IEmlakKatSayisiEngine
    {
        private readonly IEmlakKatSayisi _emlakKatSayisiRepostory;
        public EmlakKatSayisiEngine(IEmlakKatSayisi emlakKatsayisiRepostory)
        {
            _emlakKatSayisiRepostory = emlakKatsayisiRepostory;
        }
        public Task<List<EmlakKatSayisiResponse>> GetAllEmlakKatSayisiAsync()
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var emlakkatsayisi = _emlakKatSayisiRepostory.GetAll();
                return Mapper.Map<List<EmlakKatSayisiResponse>>(await emlakkatsayisi.ToListAsync());
            });
        }
    }
}
