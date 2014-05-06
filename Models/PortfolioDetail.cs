using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WaletzkoPortfolio.Models
{
    public class PortfolioDetail
    {
        [Key]
        public int ID { get; set; }
        public string Description { get; set; }
        public int PictureID { get; set; }
    }
}