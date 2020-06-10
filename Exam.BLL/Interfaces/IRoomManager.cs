using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.BLL.Interfaces
{
    public interface IRoomManager
    {
        void AddProductToRoom(Product p, Room r, int count);
        int GetProductCount(Product p);
    }
}
