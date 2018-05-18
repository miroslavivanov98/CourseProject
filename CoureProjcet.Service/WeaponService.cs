using CourseProject.DataAccess.Repositories;
using CourseProject.DB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjcet.Service
{
    class WeaponService
    {
        private readonly IBaseRepository<Weapon> repository;

        public WeaponService(IBaseRepository<Weapon> repo)
        {
            repository = repo;
        }

        public IEnumerable<Weapon> GetAll()
        {
            return repository.GetAll();
        }

        public WeaponService GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Weapon item)
        {
            // Custom validations

            if (item.Id == 0)
            {
                repository.Create(item);
            }
            else
            {
                repository.Update(item, x => x.Id == item.Id);
            }

        }
    }
}