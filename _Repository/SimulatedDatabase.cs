using Design_Patterns_Assignment._Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public class SimulatedDatabase
    {
        private List<Animal> Animals = new List<Animal>();
        private List<Customer> Customers = new List<Customer>();

     

        public void AddEntitysForDevelopmentTesting()
        {
            Animals.Add(new Animal() { Id = 1, Name = "Bengt" });
            Animals.Add(new Animal() { Id = 2, Name = "Gertrud" });
            Customers.Add(new Customer() { Id = 1, Name = "Sara" });
            Customers.Add(new Customer() { Id = 2, Name = "Peter" });
        }


        public List<Animal> GetAnimals()
        {
            return Animals;
        }

        public List<Customer> GetCustomers()
        {
            return Customers;
        }
    }
}
