using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace WebApiService.FormBuilderFactory
{
    public class EmlakFormBuilder : FormBuilderBase
    {
        public EmlakFormBuilder(FormBuilder formBuilder) : base(formBuilder)
        {
        }

        public override MvcHtmlString BuildHeader()
        {
            var sb = new StringBuilder();
            foreach (var item in base._formBuilder.Expenses)
            {
                sb.Append(item);
            }
            return MvcHtmlString.Create(sb.ToString());
        }
    }
}