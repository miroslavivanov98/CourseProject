using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseProject.DB.Entities
{
    class Shop : BaseEntity
    {

        [Required, StringLength(20)]
        public string Sity { get; set; }

        [Required, StringLength(20)]
        public string StreetName { get; set; }

        [StringLength(50)]
        public string WorkTime { get; set; }
    }
}
