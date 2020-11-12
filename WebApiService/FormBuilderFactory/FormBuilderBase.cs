using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApiService.FormBuilderFactory
{
    public abstract class FormBuilderBase
    {
        protected FormBuilder _formBuilder;
        public FormBuilderBase(FormBuilder formBuilder)
        {
            _formBuilder = formBuilder;
        }
        public abstract MvcHtmlString BuildHeader();
        public string BuildOutput()
        {
            string output = BuildHeader().ToHtmlString();
            return output;
        }
    }
}