using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Abstraction__Interface__Namespace__DLL
{
    public class Account : IAccount
    {
        public void Login(string username, string pass)
        {
            if (username == "alex" && pass == "1235678")
            {
                Console.WriteLine("Login Successful");
                return;
            }
            Console.WriteLine("Login Failed");
        }


        public void Register(string name, string username, string pass)
        {
            Console.WriteLine($"Name: {name}, Username: {username}, Password: {pass}");
        }   
    } 

    public interface IAccount
    {
        void Register(string name, string username, string pass);
        void Login(string username, string pass);
    }
}
