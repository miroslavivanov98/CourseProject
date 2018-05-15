using CourseProject.DB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.DataAccess.Repositories
{
    class ManafacturerRepository : BaseRepository<Manafacturer>
    {
        public void Save(Manafacturer Manafacturer)
        {
            if (Manafacturer.Id == 0)
            {
                Create(Manafacturer);
            }
            else
            {
                Update(Manafacturer, item => item.Id == Manafacturer.Id);
            }
        }
    }
}
