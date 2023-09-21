using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username, passWord;
            for (; ;)
            {
                Console.Write("Username: ");
                username = Console.ReadLine();
                Console.Write("Password: ");
                passWord = Console.ReadLine();

                if (username == "kklaree" && passWord == "password")
                {
                    Console.WriteLine("\nwaw korique");
                    Console.ReadLine();
                }
                else if (username != "kklaree" && passWord != "password")
                {
                    Console.WriteLine("\nPotanginamo bobo");
                    Console.ReadLine();
                }
                else if (username != "kklaree")
                {
                    Console.WriteLine("\nmali user beh");
                    Console.ReadLine();
                }
                else if (passWord != "password")
                {
                    Console.WriteLine("\nmali pass");
                    Console.ReadLine();
                }
                Console.Clear();
            }           
            
        }
    }
}