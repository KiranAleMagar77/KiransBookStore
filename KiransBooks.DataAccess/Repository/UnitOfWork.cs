﻿using KiransBooks.DataAccess.Repository.IRepository;
using KiransBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiransBooks.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork    // make the method public
    {
        private readonly ApplicationDbContext _db;   // the using statement

        public UnitOfWork(ApplicationDbContext db)
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

        public void Save()          // all the changes will be saved when the save method is called at the parent level
        {
            _db.SaveChanges();
        }
    }
}
