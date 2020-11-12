using System;
using System.Configuration;
using Torbali.Core.Common.Contracts;

namespace TorbaliBurada.Core
{
    public class ConfigurationHelper : IConfigurationHelper
    {
      
        public int DefaultTakeListMaxCount
        {
            get
            {
                return Convert.ToInt32(ConfigurationManager.AppSettings["DefaultTakeListMaxCount"]);
            }
        }

        public int DefaultTakeListMinCount
        {
            get
            {
                return Convert.ToInt32(ConfigurationManager.AppSettings["DefaultTakeListMinCount"]);
            }
        }
    }
}
