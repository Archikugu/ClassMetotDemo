using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 1;
            customer1.CustomerName = "Gokhan";
            customer1.CustomerLastName = "GOK";
            customer1.AccountNumber = 123456789;
            customer1.Balance = 789.98;



            Customer customer2 = new Customer();
            customer2.CustomerId = 2;
            customer2.CustomerName = "Fatih";
            customer2.CustomerLastName = "GOK";
            customer2.AccountNumber = 987654321;
            customer2.Balance = 3204.45;


            Customer customer3 = new Customer();
            customer3.CustomerId = 3;
            customer3.CustomerName = "Nagihan";
            customer3.CustomerLastName = "GOK";
            customer3.AccountNumber = 456789123;
            customer3.Balance = 5420.48;

            string[] customers = new string[] { customer1.CustomerName, customer2.CustomerName, customer3.CustomerName };
            foreach (var customer in customers)
            {
                Console.WriteLine("customers in the system "+" "+customer);
            }

            Console.WriteLine("---------------------");

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer3);
            customerManager.Delete(customer2);
            customerManager.Update(customer1);
            customerManager.BalanceUpdade(customer1);


            Console.ReadLine();




        }
    }
}
