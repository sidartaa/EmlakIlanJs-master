﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts;
using Torbali.Core.Common.Contracts.ResponseMessages;

namespace TorbaliBurada.Business.Contracts
{
    public interface IArsaManzaraEngine:IBusinessEngine
    {
        Task<List<ArsaManzaraResponse>> GetAllArsaManzaraAsync();
    }
}
