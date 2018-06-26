using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_10_DefaultTagHelpers.Models
{
    public class DemonstrationTagHelperViewModel
    {
        public int IntegerValue { get; set; }
        [Required]
        public string StringValue { get; set; }

        public IEnumerable<SelectListItem> ListCollection
        {
            get =>
                new List<SelectListItem>
                {
                    new SelectListItem(){
                        Text = "a",
                        Value = "a"
                    },
                    new SelectListItem(){
                        Text = "b",
                        Value = "b"
                    },
                    new SelectListItem(){
                        Text = "c",
                        Value = "c"
                    },
                    new SelectListItem(){
                        Text = "d",
                        Value = "d"
                    }
                };
        }
    }
}
