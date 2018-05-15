using CourseProject.DB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.DataAccess.Repositories
{
    class ShopRepository : BaseRepository<Shop>
    {
        public void Save(Shop Shop)
        {
            if (Shop.Id == 0)
            {
                Create(Shop);
            }
            else
            {
                Update(Shop, item => item.Id == Shop.Id);
            }
        }
    }
}
