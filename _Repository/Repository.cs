using Design_Patterns_Assignment._Repository.Models;
using Design_Patterns_Assignment._Repository.Repositories;
using System;

namespace Design_Patterns_Assignment._Repository
{
    internal class Repository
    {
        public static void Run()
        {
            SimulatedDatabase simulatedDatabase = new SimulatedDatabase();
            simulatedDatabase.AddEntitysForDevelopmentTesting();
            DataRepository dataRepository = new DataRepository(simulatedDatabase);
     

            bool loop = true;

            while (loop)
            {
                Console.WriteLine("1: Add Animal");
                Console.WriteLine("2: Add Customer");
                Console.WriteLine("3: Add Data");
                Console.WriteLine("4: Get Data");
                Console.WriteLine("5: Get specfic animal");
                Console.WriteLine("6: Get specfic Customer");
                Console.WriteLine("X: Stop Application");
                Console.WriteLine("");

                char userInput = Console.ReadKey(true).KeyChar;
                switch (userInput)
                {
                    case '1':
                        Console.Clear();
                        Console.WriteLine("Add Animal!");
                        Animal _animal = new Animal();
                        Console.WriteLine("Whats the animals name?");
                        _animal.Name = Console.ReadLine();
                        _animal.Id = dataRepository.GetAnimals().Count + 1;
                        dataRepository.SaveAnimal(_animal);
                        KeyMessage();

                        break;

                    case '2':
                        Console.Clear();
                        Console.WriteLine("Add Customer!");
                        Customer _customer = new Customer();
                        Console.WriteLine("Whats your name?");
                        _customer.Name = Console.ReadLine();
                        _customer.Id = dataRepository.GetCustomers().Count + 1;
                        dataRepository.SaveCustomer(_customer);
                        KeyMessage();

                        break;

                    case '3':
                        Console.Clear();
                        dataRepository.Save("This is some data");
                        KeyMessage();
                        break;

                    case '4':
                        Console.Clear();
                        Console.WriteLine("What kind of data would you like to get(animals/customers)?");
                        dataRepository.LoadData(Console.ReadLine());
                        KeyMessage();

                        break;

                    case '5':
                        Console.Clear();
                        dataRepository.LoadData("Animals");
                        Console.WriteLine("Please type in the id of the animal you wanna get.");
                        bool tryloop = true;
                        while (tryloop)
                            try
                            {
                                var id = Convert.ToInt32(Console.ReadLine());
                                var getAnimal = dataRepository.LoadAnimal(id);
                                if (getAnimal != null)
                                {
                                    Console.WriteLine($"{getAnimal.Name} has been retrieved!");
                                    KeyMessage();
                                    tryloop = false;
                                }
                                else
                                {
                                    Console.WriteLine("Theres no animal assigned to id: " + id);
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Only numbers!");
                            }
                        break;

                    case '6':
                        Console.Clear();
                        dataRepository.LoadData("Customers");
                        Console.WriteLine("Please type in the id of the animal you wanna get.");
                        tryloop = true;
                        while (tryloop)
                            try
                            {
                                var id = Convert.ToInt32(Console.ReadLine());
                                var getCustomer = dataRepository.LoadCustomer(id);
                                if (getCustomer != null)
                                {
                                    Console.WriteLine($"{getCustomer.Name} has been retrieved!");
                                    KeyMessage();
                                    tryloop = false;
                                }
                                else
                                {
                                    Console.WriteLine("Theres no Customer assigned to id: " + id);
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Only numbers!");
                            }

                        break;

                    case 'X' or 'x':
                        loop = false;
                        Console.Clear();
                        break;

                    default:

                  
                        Console.WriteLine("You have input a command that does nothing");
                        KeyMessage();
                        Console.Clear();
                        break;
                }
            }
        }

        public static void KeyMessage()
        {
            Console.WriteLine("Press Any Key to return to the menu.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}