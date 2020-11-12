using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Linq;
using Torbali.Core.Common.Contracts.RequestMessages;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;
using TorbaliBurada.Entity.Contracts;
using TorbaliBurada.Data.CodeFirst.Entity;

namespace TorbaliBurada.Business
{
    public class EmlakBinaYasiEngine : BusinessEngineBase, IEmlakBinaYasiEngine
    {
        private readonly IEmlakBinaYasi _EmlakBinaYasiRepostory;
        public EmlakBinaYasiEngine(IEmlakBinaYasi EmlakBinaYasiRepostory)
        {
            _EmlakBinaYasiRepostory = EmlakBinaYasiRepostory;
        }

        public Task<EmlakBinaYasiResponse> CreateAsync(BinaYasiRequest request)
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var emlakbinayasi = Mapper.Map<EmlakBinaYasi>(request);
                _EmlakBinaYasiRepostory.Add(emlakbinayasi);
                await _EmlakBinaYasiRepostory.SaveChangeAsync();
                return Mapper.Map<EmlakBinaYasiResponse>(emlakbinayasi);
            });
        }

        public Task DeleteAsync(int id)
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                await _EmlakBinaYasiRepostory.Delete(id);

                await _EmlakBinaYasiRepostory.SaveChangeAsync();
            });
        }
        Task<List<EmlakBinaYasiResponse>> IEmlakBinaYasiEngine.GetAllBinaYasiAsync()
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var binayasi = _EmlakBinaYasiRepostory.GetAll();
                return Mapper.Map<List<EmlakBinaYasiResponse>>(await binayasi.ToListAsync());
            });
        }
        
        public Task<EmlakBinaYasiResponse> GetAsync(int BinaYasiID)
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var binayasi = await _EmlakBinaYasiRepostory.GetAsync(BinaYasiID);
                return Mapper.Map<EmlakBinaYasiResponse>(binayasi);
            });
        }

        public async Task<List<EmlakBinaYasiResponse>> SearchAsync(BinaYasiSearchRequest request)
        {
            return await base.ExecuteWithExceptionHandledOperation(async () =>
            {
                if (request.take==0)
                {
                    request.take = ConfigurationHelper.DefaultTakeListMinCount;
                }
                var search = _EmlakBinaYasiRepostory.GetAll(request.skip,request.take);
                if(!string.IsNullOrEmpty(request.ProductName))
                {
                    search = search.Where(x=>x.BinaYasi.Contains(request.ProductName));
                }

                return Mapper.Map<List<EmlakBinaYasiResponse>>(await search.ToListAsync());

            });
        }

        public Task<EmlakBinaYasiResponse> UpdateAsync( BinaYasiUpdateRequest request)
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var emlakbinayasi = Mapper.Map<EmlakBinaYasi>(request);
                _EmlakBinaYasiRepostory.Update(emlakbinayasi);
                await _EmlakBinaYasiRepostory.SaveChangeAsync();
                return Mapper.Map<EmlakBinaYasiResponse>(emlakbinayasi);
            });
        }

        Task<List<EmlakBinaYasiResponse>> IEmlakBinaYasiEngine.GetAllAsync(int skip, int take)
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var binayasi = _EmlakBinaYasiRepostory.GetAll(skip, take);
                

                return Mapper.Map<List<EmlakBinaYasiResponse>>(await binayasi.ToListAsync());
            });
        }

        
    }
}
