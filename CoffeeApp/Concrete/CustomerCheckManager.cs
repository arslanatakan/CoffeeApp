using CoffeeApp.Abstract;
using CoffeeApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApp.Concrete
{
    public class CustomerCheckManager:ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            //burası artık kendi servisimiz gibi oldu.
            //test ortamında çalışırken burayı kullanarak deneyebilirim kodlarımı.
            //illa gerçek  bilgiye gerek kalmaz bu durumda (mernis vs. doğrulama için)
            return true;
        }
    }
}
