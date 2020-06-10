using Exam.DAL.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.DAL.RepositoryImpl
{
    class ProductRepository : IProductRepository, Repository<Product>
    {
    }
}
