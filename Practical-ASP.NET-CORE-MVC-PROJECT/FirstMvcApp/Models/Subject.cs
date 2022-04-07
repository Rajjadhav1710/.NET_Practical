using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMvcApp.Models
{
    public class Subject
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Subject_Name { get; set; }

        public string syllabus { get; set; }

        [Range(1,5)]
        public int credits { get; set; }
    }
}
