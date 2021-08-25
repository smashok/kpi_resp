using System;

namespace Lab1_1
{
    public class Customer
    {
        public string Name { get; set; }
        public int ID { get; set; }
        private string Username { get; set; }
        private string Pass { get; set; } 


        public Customer(string n, string u, string p)
        {
            Random random = new Random();
            Name = n;
            Username = u;
            Pass = p;
            ID = random.Next(1, 10000);
        }

        public override string ToString()
        {
            return string.Format("Customer {0}   ID {1} ", Name, ID);
        }

        public bool CheckLogin(string login, string pass)
        {
            return (login == Username && Pass == pass);
        }
    }
}