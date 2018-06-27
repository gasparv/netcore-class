using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_11_CustomTagHelpers.Helpers.HelperModels
{
    public class Enums
    {
        //Defines the Bootstrap style types that are used in various scenarios not only for the label class value
        public enum DefaultStyles {None,Primary,Warning,Danger,Default,Info }
        //Private dictionary that pairs the enum type as the key with a string value that represents the styling part of the css class style 
        private Dictionary<DefaultStyles, string> BootstrapStyles
        {
            get => new Dictionary<DefaultStyles, string>()
            {
                { DefaultStyles.None,"" },
                { DefaultStyles.Primary,"-primary" },
                { DefaultStyles.Warning,"-warning"},
                { DefaultStyles.Danger,"-danger"},
                { DefaultStyles.Default,"-default"},
                { DefaultStyles.Info,"-info"}
            };
        }
        //Method that retrieves the style string based on the selected enum
        public string GetStyleString(DefaultStyles style)
        {
            return BootstrapStyles.FirstOrDefault(x =>x.Key == style).Value;
        }
    }
}
