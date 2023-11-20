using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiransBooks.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        ICoverTypeRepository CoverType { get; }  // add properties for covertypr repository

        IProductRepository Product { get; }  // add properties for covertypr repository
        ISP_Call SP_Call { get; }

        void Save();
    }
}
