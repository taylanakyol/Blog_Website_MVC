using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }
        [Display(Name ="writer name")]
        public string WriterName { get; set; }
        public string WriterAbout { get; set; }
        [Display(Name = "writer image")]
        public string WriterImage { get; set; }
        [Display(Name = "writer e-mail")]
        public string WriterMail { get; set; }
        [Display(Name = "password")]
        public string WriterPassword { get; set; }
        public bool WriterStatus { get; set; }
        public List<Blog>? Blogs { get; set; }

    }
}
