using System;
using System.Collections.Generic;

namespace Torbali.Core.Common.Contracts
{
    public interface ILogger
    {
        void Info(string message, Dictionary<string,string> additionalColums=null);
        void LogError(string message, Exception exception, Dictionary<string, string> additionalColums = null);
    }
}
