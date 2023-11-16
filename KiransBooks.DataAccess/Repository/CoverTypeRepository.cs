using KiransBooks.DataAccess.Repository.IRepository;
using KiransBooks.Models;
using KiransBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiransBooks.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CoverType coverType)
        {
            // Use .NET LINQ to retrieve the first or default CoverType object
            // then pass the id as a generic entity which matches the CoverType ID
            var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.Id == coverType.Id);
            if (objFromDb != null) // Save changes if not null
            {
                objFromDb.Name = coverType.Name;
                // _db.SaveChanges();
            }
        }
    }
}
