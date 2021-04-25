using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Name = "Furkan";
            customer.Surname = "Turan";
            customer.Id = 1;
            customer.Email = "furkanturan10r@hotmail.com";

            CustomerService customerService = new CustomerService();
            customerService.Add(customer);
            customerService.Delete(customer);
            customerService.List(customer);

            Console.WriteLine(customer.Name);
        }
    }
}
