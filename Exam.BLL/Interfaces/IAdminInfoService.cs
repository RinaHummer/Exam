using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.BLL.Interfaces
{
    public interface IAdminInfoService
    {
        void GetSumCost();
        void AddProduct(Product p, string warehouse);
        void DeleteProduct(Product p);

    }
}
