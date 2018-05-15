using CourseProject.DB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.DataAccess.Repositories
{
     class WeaponRepository : BaseRepository<Weapon>
    {
        public void Save(Weapon Weapon)
        {
            if (Weapon.Id == 0)
            {
                Create(Weapon);
            }
            else
            {
                Update(Weapon, item => item.Id == Weapon.Id);
            }
        }
    }
}
