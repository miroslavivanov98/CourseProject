using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseProject.DB.Entities
{
    class Weapons : BaseEntity
    {
        [Required, StringLength(50)]
        [Index("IX_WeaponsNameUnique", IsUnique = true)]
        public string Name { get; set; }

        [Required]
        public int Caliber { get; set; }

        [Required, StringLength(20)]
        public string Weight { get; set; }

        [Required, StringLength(20)]
        public string BarrelLength { get; set; }

        [Required, StringLength(20)]
        public string Price { get; set; }


    }
}
