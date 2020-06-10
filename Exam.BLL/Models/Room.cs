using Exam.BLL.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.BLL.Models
{
    class Room
    {
        public string Type { get; set; }
        public int Id { get; set; }
        public List<Product> Products { get; set; }
        public void AddProduct(Product p)
        {

        }
    }
}
