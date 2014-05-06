using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WaletzkoPortfolio.Models
{
    public class ContactInfo
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string value { get; set; }
    }
}