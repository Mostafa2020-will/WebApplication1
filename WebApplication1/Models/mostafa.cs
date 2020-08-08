using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI.WebControls;

namespace WebApplication1.Models
{
    public class mostafa
    {
        public int id { get; internal set; }
        [Display]
        [Required(ErrorMessage ="please input name")]
        [StringLength(50)]
        public string name { get; set; }
        public string city { get; set; }
        public string email { get; internal set; }
    }
}