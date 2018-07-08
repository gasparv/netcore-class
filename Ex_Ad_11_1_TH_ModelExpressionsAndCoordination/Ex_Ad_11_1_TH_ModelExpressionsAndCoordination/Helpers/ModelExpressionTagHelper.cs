using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_Ad_11_1_TH_ModelExpressionsAndCoordination.Helpers
{
    [HtmlTargetElement("input",TagStructure=TagStructure.WithoutEndTag)]
    public class ModelExpressionTagHelper : TagHelper
    {
        public ModelExpression StringValueFor { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("for", StringValueFor.Name);
            output.Attributes.SetAttribute("value", StringValueFor.Model);
            
        }
    }
}
