using EcoPower_Logistics.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EcoPower_Logistics.Repository
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CellPhone { get; set; } = null!;
        public string CustomerName { get; set; } = null!;
        public string CustomerSurname { get; set; } = null!;
        public string CustomerTitle { get; set; } = null!;
    }
    public class CustomerRepository
    {
        private List<Customer> customers;

        public CustomerRepository()
        {
            customers = new List<Customer>();
        }

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public Customer GetCustomerById(int customerId)
        {
            var customer = customers.FirstOrDefault(c => c.CustomerId == customerId);
            if (customer == null)
            {
                throw new InvalidOperationException("Customer not found");
            }
            return customer;
        }

        public List<Customer> GetAllCustomers()
        {
            return customers;
        }

        public void UpdateCustomer(Customer customer)
        {
            var existingCustomer = customers.FirstOrDefault(c => c.CustomerId == customer.CustomerId);
            if (existingCustomer != null)
            {
                existingCustomer.CellPhone = customer.CellPhone;
                existingCustomer.CustomerName = customer.CustomerName;
                existingCustomer.CustomerSurname = customer.CustomerSurname;
                existingCustomer.CustomerTitle = customer.CustomerTitle;
            }
        }

        public void DeleteCustomer(int customerId)
        {
            var customer = customers.FirstOrDefault(c => c.CustomerId == customerId);
            if (customer != null)
            {
                customers.Remove(customer);
            }
        }
    }
}
