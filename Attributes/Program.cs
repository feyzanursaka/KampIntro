using System;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer{ Id=1,LastName="Saka",Age=24};
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine();

        }
        [ToTable("Customers")]
        class Customer
        {
            public int Id { get; set; }
            [RequiredProperty]
            public string FirstName { get; set; }
            [RequiredProperty]
            public string LastName { get; set; }
            public int Age { get; set; }
        }
        class CustomerDal
        {
            [Obsolete("Dont use Add, instead use AddNew Method")]
            public void Add(Customer customer)
            {
                Console.WriteLine("{0},{1},{3} added!",
                    customer.Id,customer.FirstName,customer.LastName,customer.Age);
            }
            public void AddNew(Customer customer)
            {
                Console.WriteLine("{0},{1},{3} added!",
                    customer.Id, customer.FirstName, customer.LastName, customer.Age);
            }
        }
        class RequiredPropertyAttribute : Attribute
        {

        }
        class ToTableAttribute : Attribute
        {
            private string _tableName;
            public ToTableAttribute(string tableName)
            {
                _tableName = tableName;
            }
        }
    }
}
