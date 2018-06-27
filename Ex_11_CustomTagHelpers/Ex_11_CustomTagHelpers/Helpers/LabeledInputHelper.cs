using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Ex_11_CustomTagHelpers.Helpers.HelperModels;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Ex_11_CustomTagHelpers.Helpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    //The tag is names labeled-input and its structure is defined to be self-closing = withoutEndTag
    //There are no restrictions to contents whatsoever - mostly because the tag is self-closing
    [HtmlTargetElement("labeled-input",TagStructure=TagStructure.WithoutEndTag)]
    public class LabeledInputHelper : TagHelper
    {
        //Injection of the Enums service that contains enum models used for options definition in tag helper attributes
        private readonly Enums _enums;
        //Constructor injection
        public LabeledInputHelper(Enums enums)
        {
            _enums = enums;
        }

        //Attribute parameter of type DefaultStyles - option attribute that cant be null. Default value is set to none, although the enums will have their first value as default (by default :) ) 
        public Enums.DefaultStyles LabelStyle { get; set; } = Enums.DefaultStyles.None;
        /*Other attributes that relate to the labeled-input tag - 
            name = label for & input name
            Value = default value of the input
            Label = text in the label
            Placeholder = placeholder of the input tag
            Type = could be an enum - decided to be plain text :) ... 
        */
        public string Name { get; set; }
        public string Value { get; set; }
        public string Label { get; set; }
        public string Placeholder { get; set; }
        public string Type { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //TagName is empty because there is no upper container (div or span) that we want to use as a parent tag
            output.TagName = "";
            
            //just for inline clarity - this condition hardcodes the label plain text and adds the bootstrap specific style
            string labelstring = LabelStyle == Enums.DefaultStyles.None ? "" : $"label label{ _enums.GetStyleString(LabelStyle)}";

            //Appends the HTML content to the output of the tagHelper
            output.Content.AppendHtml($@"
            <label for='{Name}' class='{labelstring}'>{Label}</label>
            <input name='{Name}' class='form-control' value='{Value}' placeholder='{Placeholder}' type='{Type}'/>
");
        }
    }
}
