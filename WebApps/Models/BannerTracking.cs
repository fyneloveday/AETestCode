using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApps.Models
{
    public class BannerTracking
    {
        [Key]
        public int TrackingId { get; set; }
        [ForeignKey("Banner")]
        public int BannerId { get; set; }
        public Banner Banner { get; set; }
        public int ImpressionCount { get; set; }
        public int ClickCount { get; set; }
        public DateTime CreateDate { get; set; }
    }
}