using Design_Patterns_Assignment._Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Design_Patterns_Assignment._Repository.Repositories
{
    internal class DataRepository : IDataRepository
    {
        private List<Animal> Animals;
        private List<Customer> Customers;

        public DataRepository()
        {
            Animals = new List<Animal>();
            Customers = new List<Customer>();
        }

        public void AddEntitysForDevelopmentTesting()
        {
            Animals.Add(new Animal() { Id = 1, Name = "Bengt" });
            Animals.Add(new Animal() { Id = 2, Name = "Gertrud" });
            Customers.Add(new Customer() { Id = 1, Name = "Sara" });
            Customers.Add(new Customer() { Id = 2, Name = "Peter" });
        }

        public Animal LoadAnimal(int id)
        {
            return Animals.FirstOrDefault(a => a.Id == id);
        }

        public Customer LoadCustomer(int id)
        {
            return Customers.FirstOrDefault(a => a.Id == id);
        }

        public void LoadData(string data)
        {
            switch (data.ToLower())
            {
                case "animals":
                    foreach (var item in Animals)
                    {
                        Console.WriteLine(item.Id + " " + item.Name);
                    }
                    break;

                case "customers":
                    foreach (var item in Customers)
                    {
                        Console.WriteLine(item.Id + " " + item.Name);
                    }
                    break;

                default:
                    Console.WriteLine("Couldn´t find any data");
                    break;
            }
        }

        public List<Animal> GetAnimals()
        {
            return Animals;
        }

        public List<Customer> GetCustomers()
        {
            return Customers;
        }

        public void Save(string data)
        {
            Console.WriteLine($"Saving data \"{data}\" to SQL Database");
        }

        public void SaveAnimal(Animal animal)
        {
            Animals.Add(animal);
            Console.WriteLine($"\"{animal.Name}\" has been created and saved to SQL Database");
        }

        public void SaveCustomer(Customer customer)
        {
            Customers.Add(customer);
            Console.WriteLine($"\"{customer.Name}\" has been created and saved to SQL Database");
        }
    }
}