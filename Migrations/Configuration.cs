using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WaletzkoPortfolio.Models;
using System.Collections;

namespace WaletzkoPortfolio.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<WaletzkoPortfolio.Models.PortfolioContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
        protected override void Seed(WaletzkoPortfolio.Models.PortfolioContext context)
        {
            context.PortfolioDetails.AddOrUpdate(pd => pd.Description, new PortfolioDetail { Description = "This is Jake's website. Let's code some stuff.", PictureID = 1 });

            context.Experiences.AddOrUpdate(e => e.Name,
                new Experience { Name = "Saint John's University", Location = "Collegeville, MN", StartDate = new DateTime(2008, 8, 15), EndDate = new DateTime(2012, 5, 12), Description = "Worked as a teaching assistant", PictureID = 2 }
             );

            context.Experiences.AddOrUpdate(e => e.Name,
                new Experience { Name = "C.H. Robinson", Location = "Eden Prairie, MN", StartDate = new DateTime(2012, 5, 12), EndDate = DateTime.Now, Description = "Do coding stuff", PictureID = 3 }
             );

            context.Educations.AddOrUpdate(e => e.Name,
                new Education { Name = "Saint John's University", Location = "Collegeville, MN", Type = "College", StartDate = new DateTime(2008, 8, 15), EndDate = new DateTime(2012, 5, 12), Description = "Best college ever!", PictureID = 4 }
             );

            context.Skills.AddOrUpdate(s => s.Name,
                new Skill { Name = "C#", Description = "Doing c#", Level = 6 }
                );

            context.Skills.AddOrUpdate(s => s.Name,
                new Skill { Name = "VB.Net", Description = "Doing vb.net", Level = 7 }
                );

            context.Skills.AddOrUpdate(s => s.Name,
                new Skill { Name = "Java", Description = "Doing Java", Level = 5 }
                );

            context.Skills.AddOrUpdate(s => s.Name,
                new Skill { Name = "SQL", Description = "Doing SQL", Level = 4}
                );

            context.ContactInfo.AddOrUpdate(c => c.Name,
                new ContactInfo { Name = "Email", value = "jnwaletzko@gmail.com" }
                );

            context.Pictures.AddOrUpdate(p => p.Name,
                new Picture { Name = "test1", PictureURL = "~/Images/Gbdc6mS.jpg", LinkURL = "Education" }
                );

            context.Pictures.AddOrUpdate(p => p.Name,
                new Picture { Name = "test2", PictureURL = "~/Images/20131214_200230.jpg", LinkURL = "Experience"}
                );

            context.Pictures.AddOrUpdate(p => p.Name,
                new Picture { Name = "test3", PictureURL = "~/Images/7lBr1.jpg", LinkURL = "Skill"}
                );

            context.Pictures.AddOrUpdate(p => p.Name,
                new Picture { Name = "test4", PictureURL = "~/Images/bPvqW.jpg", LinkURL = "About"}
                );


        }
    }
}