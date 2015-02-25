using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace tomstahl.Models
{
    public class ResumeContent
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        [UIHint("tinymce_jquery_full"), AllowHtml]
        public string Content { get; set; }
    }
}