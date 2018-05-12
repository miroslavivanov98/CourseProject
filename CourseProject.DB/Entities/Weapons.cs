using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseProject.DB.Entities
{
    public class Weapons : BaseEntity
    {
        
        public int ManafacturerId { get; set; }
        [Required, ForeignKey("ManafacturerId")]
        public Manafacturer Manafacturer { get; set; }

        [Required, StringLength(50)]
        [Index("IX_WeaponsNameUnique", IsUnique = true)]
        public string Name { get; set; }

        [Required]
        public string Caliber { get; set; }

        [Required, StringLength(20)]
        public string Weight { get; set; }

        [Required, StringLength(20)]
        public string BarrelLength { get; set; }



        [Required, StringLength(20)]
        public string Price { get; set; }


    }
}
