using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiService.FormBuilderFactory
{
    public class BuilderManeger
    {
        private FormBuilderBase _formBuilderBase;
        public BuilderManeger(FormBuilderBase formBuilderBase)
        {
            _formBuilderBase = formBuilderBase;
        }
        public string Build()
        {
            string build = _formBuilderBase.BuildOutput();
            return build;
        }
    }
}