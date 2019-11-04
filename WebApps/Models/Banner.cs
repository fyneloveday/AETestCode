using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApps.Models
{
    public class Banner
    {
        [Key]
        public int BannerId { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public string Image { get; set; }
        public string AltText { get; set; }
        public string Target { get; set; }
        public bool IsActive { get; set; }
    }
}