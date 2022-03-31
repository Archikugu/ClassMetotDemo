using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " " + customer.CustomerLastName+" " + "Successfully added to the system");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " " + customer.CustomerLastName + " " + "Successfully deleted from the system");
        }
        public void Update(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " " + customer.CustomerLastName + " " + "customer information updated");
        }
        public void BalanceUpdade(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " " + customer.Balance + " " + "Balance updated !!");
        }

    }
}
