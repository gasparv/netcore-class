using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_Ad_11_1_TH_ModelExpressionsAndCoordination.Helpers
{
    [HtmlTargetElement("div", Attributes = "theme")]
    public class FormGroupTagHelper : TagHelper
    {
        public string Theme { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            context.Items["theme"] = Theme;
            output.TagName = "div";
            output.Attributes.SetAttribute("class", "form-group");
        }
    }

    [HtmlTargetElement("button", ParentTag = "div")]
    [HtmlTargetElement("a", ParentTag = "div")]
    public class ThemeButton : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (context.Items.ContainsKey("theme"))
                output.Attributes.SetAttribute("class", $"btn btn-{context.Items["theme"] }");
        }
    }
}
