using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public int Money { get; set; }


        public Client(int money , string firstname, int id) 
        {
            Id = id;
            FirstName = firstname;
            Money = money;
        }
        

    }
}
