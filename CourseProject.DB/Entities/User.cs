using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseProject.DB.Entities
{
    class User : BaseEntity
    {
        [Required, StringLength(20)]
        public string Email { get; set; }

        [Required, StringLength(20)]
        public string PassHash { get; set; }

        [Required, StringLength(20)]
        public bool IsAdmin { get; set; }

        [Required, StringLength(20)]
        public bool IsBanned { get; set; }

    }
}
