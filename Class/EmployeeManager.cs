using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class EmployeeManager : BaseManager
    {
        public EmployeeManager()
        {

        }
        public void ViewAll()
        {
            Console.WriteLine("View All");
            base.AddNew();
        }
    }
}
