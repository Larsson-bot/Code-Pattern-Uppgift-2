using Design_Patterns_Assignment._Repository.Interfaces;
using Design_Patterns_Assignment._Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment._Repository.Repositories
{
    public interface IDataRepository
    {
        void LoadData(string data);

        Animal LoadAnimal(int id);
        Customer LoadCustomer(int id);

        public List<Animal> GetAnimals();
        public List<Customer> GetCustomers();

        void SaveCustomer(Customer customer);
        void SaveAnimal(Animal animal);
    }
}
