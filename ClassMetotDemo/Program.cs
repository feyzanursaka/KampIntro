using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.FirstName = "Kerem";
            customer1.LastName = "Yılmaz";
            customer1.BirthYear = 1996;

            Customer customer2 = new Customer();
            customer2.FirstName = "Tolga";
            customer2.LastName = "Yıldız";
            customer2.BirthYear = 1995;

            Customer customer3 = new Customer();
            customer3.FirstName = "Hasan";
            customer3.LastName = "Yıldı";
            customer3.BirthYear = 1994;

            Customer customer4 = new Customer();
            customer4.FirstName = "Ali";
            customer4.LastName = "Yaldız";
            customer4.BirthYear = 1993;

            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4 };

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);

            Console.WriteLine("--------------------");

            customerManager.Delete(customer1);
            customerManager.Delete(customer2);
            customerManager.Delete(customer3);
            customerManager.Delete(customer4);

            Console.WriteLine("--------------------");

            customerManager.Update(customer1);
            customerManager.Update(customer2);
            customerManager.Update(customer3);
            customerManager.Update(customer4);

            Console.WriteLine("--------------------");

            customerManager.List(customers);

        }
    }
}
