using ShalilsBooks.DataAccess.Repository.IRepository;
using ShalilsBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShalilsBooks.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork //make the method to access the class
    {
        private readonly ApplicationDbContext _db;  //the using statement

        public UnitOfWork(ApplicationDbContext db) // constructor
        {
            _db = db;
            Category = new CategoryRepository(_db);
            CoverType = new CoverTypeRepository(_db);
            Product = new ProductRepository(_db);
            SP_Call = new SP_Call(_db);
        }
        public ICategoryRepository Category { get; private set; }
        public ICoverTypeRepository CoverType { get; private set; }
        public IProductRepository Product { get; private set; }
        public ISP_Call SP_Call { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save() //all changes will be saved
        {
            _db.SaveChanges();
        }
    }
}
