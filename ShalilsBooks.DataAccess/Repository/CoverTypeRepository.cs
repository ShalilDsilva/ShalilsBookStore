using ShalilsBookStore.DataAccess.Data;
using ShalilsBooks.DataAccess.Repository.IRepository;
using ShalilsBooks.Models;
using System.Linq;

namespace ShalilsBooks.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ShalilsBookStore.DataAccess.Data.ApplicationDbContext _db;

        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CoverType coverType)
        {
            var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.Id == coverType.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = coverType.Name;

            }
        }
    }
}
