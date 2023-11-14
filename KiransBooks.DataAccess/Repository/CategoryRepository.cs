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
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            //use .NET lINQ to retrive the first or default category object
            // then pass the id as a generic entity which matches the category ID
            var objFormDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFormDb != null) ///save changes if not null
            {
                objFormDb.Name = category.Name;
                //_db.SaveChanges();
            }
        }
    }
}
