using CourseProject.DB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.DataAccess.Repositories
{
    class CategoryRepository : BaseRepository<Category>
    {
        public void Save(Category Category)
        {
            if (Category.Id == 0)
            {
                Create(Category);
            }
            else
            {
                Update(Category, item => item.Id == Category.Id);
            }
        }
    }
}
