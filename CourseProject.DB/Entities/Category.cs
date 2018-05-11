using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseProject.DB.Entities
{
    class Category : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; }
    }
}
