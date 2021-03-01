using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName + ": Kayıt oldu");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + ": Kayıt silindi");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + ": Kayıt güncellendi");
        }

        public void List(Customer[] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
                Console.WriteLine(customer.LastName);
                Console.WriteLine(customer.BirthYear);
                Console.WriteLine("--------------------");
            }
            Console.WriteLine("Kayıtlar listelendi");
        }
    }
}
