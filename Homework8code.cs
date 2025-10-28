namespace Homework8;
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Customer cus1 = new Customer(customerName: "Alice", customerAge: 33, customerCity: "Amarillo", customerCredit: 198.5);
        Customer cus2 = new Customer(customerName: "Bob", customerAge: 23, customerCity: "Amarillo", customerCredit: 226);
        Customer cus3 = new Customer(customerName: "Cathy", customerAge: 45, customerCity: "Amarillo", customerCredit: 89.0);
        Customer cus4 = new Customer(customerName: "David", customerAge: 58, customerCity: "Amarillo", customerCredit: 198.5);
        Customer cus5 = new Customer(customerName: "Jack", customerAge: 28, customerCity: "Canyon", customerCredit: 561.6);
        Customer cus6 = new Customer(customerName: "Tom", customerAge: 36, customerCity: "Canyon", customerCredit: 98.4);
        Customer cus7 = new Customer(customerName: "Tony", customerAge: 24, customerCity: "Canyon", customerCredit: 18.5);
        Customer cus8 = new Customer(customerName: "Sam", customerAge: 35, customerCity: "Canyon", customerCredit: 228.3);
        Customer[] customer_list = { cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8 };
        TotalCredits(customer_list);
        Console.WriteLine();
        AmarilloAverageAge(customer_list);
        Console.WriteLine();
        CanyonAge(customer_list);
    }
    public static void TotalCredits(Customer[] customer_list)
    {
        double totalCredit = customer_list.Sum(c => c.customerCredit);
        Console.WriteLine($"Q1: The total credits: {totalCredit:C}");
    }
    public static void AmarilloAverageAge(Customer[] customer_list)
    {
        var amarilloCustomers = customer_list.Where(c => c.customerCity == "Amarillo");
        if (amarilloCustomers.Any())
        {
            double averageAge = amarilloCustomers.Average(c => c.customerAge);
            Console.WriteLine($"Q2: The average age of customers in Amarillo: {averageAge:F2}");
        }
        else
        {
            Console.WriteLine("No customers found in Amarillo.");
        }
    }
    public static void CanyonAge(Customer[] customer_list)
    {
        var filteredCustomers = customer_list.Where(c => c.customerCity == "Canyon" && c.customerAge > 30);

        Console.Write("Customers who live in Canyon and over 30 years old:");
        if (filteredCustomers.Any())
        {
            foreach (var customer in filteredCustomers)
            {
                Console.Write($"{customer.customerName},");
            }
        }
        else
        {
            Console.WriteLine("None found.");
        }
    }
}
public class Customer
{

    public string customerName { get; set; }
    public int customerAge { get; set; }
    public string customerCity { get; set; }
    public double customerCredit { get; set; }

    public Customer(string customerName, int customerAge, string customerCity, double customerCredit)
    {
        this.customerName = customerName;
        this.customerAge = customerAge;
        this.customerCity = customerCity;
        this.customerCredit = customerCredit;
    }
    
}

