using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using tomstahl.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace tomstahl.DAL
{
    public class ResumeContext : ApplicationDbContext
    {
        public ResumeContext() : base("ResumeContext")
        {
        }
        
        public DbSet<ResumeContent> ResumeContents { get; set; }
    }
}