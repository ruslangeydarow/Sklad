using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklad
{
    enum Status
    {
        Taken,
        Warehouse,
        Sold
    }
    public class Model
    {
        public string Product;
        public int Count;
        public DateTime StatusChange;
        public string status;

        public string StringForDB()
        {
            return "'" + Product + "','" + Count + "','" + StatusChange.ToString() + "','" + status + "'";
        }
    }
}
