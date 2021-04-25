using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerService
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name + " başarılı bir şekilde eklendi.");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Name + " başarılı bir şekilde silindi.");
        }
        public void List(Customer customer)
        {
            Console.WriteLine(customer.Name + " başarılı bir şekilde listeye eklendi.");
        }
    }
}
