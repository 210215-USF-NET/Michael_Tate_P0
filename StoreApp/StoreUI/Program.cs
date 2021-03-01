using StoreBL;
using StoreDL;
using StoreDL.Entities;
using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.EntityFrameworkCore;


namespace StoreUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //get configuration file
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory()) 
            .AddJsonFile("appsettings.json")
            .Build();

            //setting up db connection
            string connectionString = configuration.GetConnectionString("StoreAppDB");
            DbContextOptions<StoreAppDBContext> options = new DbContextOptionsBuilder<StoreAppDBContext>()
            .UseSqlServer(connectionString)
            .Options;

            //using statement used to dispose of the context when its no longer used
            using var context = new StoreAppDBContext(options);

            IMenu menu = new StoreMenu(new CustomerBL(new CustomerRepoDB(context, new CustomerMapper())));
            menu.Start();
        }
    }
}
/*
Store App
Overview:
The store app is a software that helps customers purchase products from your business. Designed with functionality that would make virtual shopping much simpler!

Functionality:
add a new customer (done) 
search customers by name (need help saving and searching to DB)
display details of an order (need DB for this)
place orders to store locations for customers
view order history of customer
view order history of location
view location inventory
The customer should be able to purchase multiple products (need to ctreate a cart, how the fuck do i do that!!!)
Order histories should have the option to be sorted by date (latest to oldest and vice versa) or cost (least expensive to most expensive)
The manager should be able to replenish inventory

Models:
Customer
Location
Orders
Product
Note: add as much models as you would need for your design

Additional requirements:
Exception Handling (somr done more still needs to be added)
Input validation (somr done more still needs to be added)
Logging
At least 10 unit tests (1 done)
Data should be persisted, (no data should be hard coded)
You should use SQLServer DB (using)
DB structure should be 3NF
Should have an ER Diagram (was never shown how to make one of these)
Code should have xml documentation

Tech Stack:
C#
SQLServer DB
EF Core
Xunit
Serilog or Nlog
*/

