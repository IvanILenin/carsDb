using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars.Data;

namespace Cars.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Manufacturer> mans = new List<Manufacturer>();
            using (Context dbContext = new Context())
            {
                mans = dbContext.Manufacturers.ToList();
            }
            foreach (var item in mans)
            {
                Console.WriteLine("{0} from {1}", item.Name, item.Country);
            }
            Console.ReadKey();

        }
    }
}
