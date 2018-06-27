using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Ex_11_CustomTagHelpers.Helpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("form-group")]
    //Restricts the elements that can be used inside the form-group taghelper
    [RestrictChildren("label","input","select","a")]
    public class FormGroupHelper : TagHelper
    {
        //"override of the HTML class attribute to force some classes and add more"
        public string Class { get; set; }
        
        //async task ProcessAsync is used beucase the GetChildContentAsync method is used
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            //Sets the outer container of the taghelper - tag that is substituted for the form-group tag
            output.TagName = "div";
            //Declares that the outer container is a pair tag
            output.TagMode = TagMode.StartTagAndEndTag;
            //Adds the class attribute with fixed value and values based on its content
            output.Attributes.Add(new TagHelperAttribute("class", "form-group" + (String.IsNullOrEmpty(Class) ? (" " + Class) : Class)));

            //Gets the inner content of the form-group tag (all its children) and adds them to the output of the taghelper
            output.Content.AppendHtml(await output.GetChildContentAsync());
        }
    }
}
