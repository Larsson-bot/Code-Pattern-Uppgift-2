using Design_Patterns_Assignment._Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment._Repository.Models
{
    public class Customer : ICustomer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
