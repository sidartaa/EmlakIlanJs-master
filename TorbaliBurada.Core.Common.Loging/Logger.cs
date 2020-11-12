using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Torbali.Core.Common.Contracts;

namespace TorbaliBurada.Core.Common.Loging
{
    public class Logger : ILogger
    {
        private readonly log4net.ILog _log;
            public Logger()
        {
            log4net.Config.XmlConfigurator.Configure(new FileInfo(AppDomain.CurrentDomain.BaseDirectory+"log4.config"));
            _log = log4net.LogManager.GetLogger(GetType().FullName);
        }
        public void Info(string message, Dictionary<string, string> additionalColums = null)
        {
            System.Diagnostics.Contracts.Contract.Assert(!string.IsNullOrEmpty(message));
            BindAdditionalColumnsIfNotEmpaty(additionalColums);

            _log.Info(message);
        }

        public void LogError(string message, Exception exception, Dictionary<string, string> additionalColums = null)
        {
            System.Diagnostics.Contracts.Contract.Assert(!string.IsNullOrEmpty(message));
            System.Diagnostics.Contracts.Contract.Assert(exception!=null);
            _log.Error(message,exception);
        }

        private void BindAdditionalColumnsIfNotEmpaty(Dictionary<string, string> additionalColumns)
        {
            if (additionalColumns!=null && additionalColumns.Any())
            {
                foreach (var item in additionalColumns)
                {
                    log4net.ThreadContext.Properties[item.Key] = item.Value;
                }
            }

        }
    }
}
