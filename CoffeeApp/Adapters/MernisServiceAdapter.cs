using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeApp.Abstract;
using CoffeeApp.Entities;
using CoffeeApp.MernisServiceReference;
namespace CoffeeApp.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityId),customer.FirstName.ToUpper(),customer.LastName.ToUpper(),customer.DateOfBirth.Year);
        }
    }
}
