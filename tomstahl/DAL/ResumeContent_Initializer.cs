using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using tomstahl.Models;

namespace tomstahl.DAL
{
    public class ResumeContent_Initializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<ResumeContext>
    {
        protected override void Seed(ResumeContext context)
        {
            new ResumeContent { ID = 1, Content = "This is test content from the <i>Database</i>." };
            base.Seed(context);
        }
    }
}