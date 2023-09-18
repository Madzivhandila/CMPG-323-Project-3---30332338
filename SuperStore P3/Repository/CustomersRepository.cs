using System;
using System.Collections.Generic;
using System.Linq;

// Define your Customer entity class
public class Customer
{
    public int CustomerId { get; set; }
    public string CellPhone { get; set; } = null!;
    public string CustomerName { get; set; } = null!;
    public string CustomerSurname { get; set; } = null!;
    public string CustomerTitle { get; set; } = null!;
}

// Create a repository class for Customers
public class CustomerRepository
{
    private List<Customer> customers; // Simulating an in-memory data store

    public CustomerRepository()
    {
        customers = new List<Customer>();
    }

    public void AddCustomer(Customer customer)
    {
        // Implement logic to add a customer to the database
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
        // In a real application, you should retrieve customers from a database or another data source.
        // This method is for illustration purposes only.
        return customers;
    }

    public void UpdateCustomer(Customer customer)
    {
        // Implement logic to update a customer in the database.
        // Update the appropriate properties based on your database structure.
        // For this example, assume the properties are directly updatable.
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
        // Implement logic to delete a customer from the database.
        // This is a simple example, and you should adapt it to your database access method.
        var customerToDelete = customers.FirstOrDefault(c => c.CustomerId == customerId);
        if (customerToDelete != null)
        {
            customers.Remove(customerToDelete);
        }
    }
}
