using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WaletzkoPortfolio.Models
{
    public class Picture
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string LinkURL { get; set; }
        public string PictureURL { get; set; }
    }
}