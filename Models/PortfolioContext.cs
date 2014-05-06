using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WaletzkoPortfolio.Models
{
    public class PortfolioContext: DbContext
    {
        public PortfolioContext(): base("name=DefaultConnection")
        {

        }
        public DbSet<PortfolioDetail> PortfolioDetails { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<ContactInfo> ContactInfo { get; set; }
        public DbSet<Picture> Pictures { get; set; }
    }
}