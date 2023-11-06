using ShalilsBooks.DataAccess.Repository.IRepository;
using ShalilsBooks.Models;
using ShalilsBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ShalilsBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)     
        {
            _db = db;
        }

        public void Update(Category category)
        {
            //use .NET LINQ to retrieve the first or default category object
            // then pass the id as a generic entity which matches the category id
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if(objFromDb != null) //save changes if not null
            {
                objFromDb.Name = category.Name;
                _db.SaveChanges();
            }
        }
    }
}
