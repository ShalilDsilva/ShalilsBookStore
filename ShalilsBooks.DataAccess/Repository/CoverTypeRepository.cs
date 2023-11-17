using ShalilsBooks.DataAccess.Repository.IRepository;
using ShalilsBooks.Models;
using ShalilsBookStore.DataAccess.Data;
using System;
using System.Linq;

namespace ShalilsBooks.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;
        //private readonly IUnitOfWork _unitOfWork;
        
        public CoverTypeRepository(ApplicationDbContext db) : base(db)     
        {
            _db = db;
        }

        public void Update(CoverType coverType)
        {
            //use .NET LINQ to retrieve the first or default category object
            // then pass the id as a generic entity which matches the category id
            var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.Id == coverType.Id);
            if(objFromDb != null) //save changes if not null
            {
                objFromDb.Name = coverType.Name;
                _db.SaveChanges();
                //_unitOfWork.Save();
                //return RedirectToAction(nameof(Index)); //to see all categories
            }
        }

       
    }
}
