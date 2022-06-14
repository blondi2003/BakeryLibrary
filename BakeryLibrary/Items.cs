using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryLibrary
{
    public class Items : IUser
    {
        public int Id { get; set; }          //Общие переменные.
        public string Name { get; set; }
        public int Price { get; set; }
        public int Mark { get; set; }
        public string Comment { get; set; }

        public string BuyProduct()
        {
            return "";
        }

    }
}
