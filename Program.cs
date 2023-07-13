using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ValiduserName = "vasan@123";
            string Validpassword = "vth@456";
            
            

            int attempts = 3;
            while(attempts > 0)
            {
                Console.WriteLine("Enter Username:\t");
                string userName = Console.ReadLine();
                Console.WriteLine("Enter Password");
                string password = Console.ReadLine();

                if (userName == ValiduserName && password == Validpassword) 
                {
                    Console.WriteLine("Login Successfull!");
                    break;
                    
                }

                else if(userName == ValiduserName) {
                    Console.WriteLine("Enter the valid Password");
                    attempts--;
                    Console.WriteLine($"You have {attempts} remaining attempts");
                }
                else
                {
                    Console.WriteLine("Enter the Valid Username");
                    attempts--;
                    Console.WriteLine($"You have {attempts} remaining attempts");

                }
                
                if (attempts == 0)
                {
                    Console.WriteLine("Login Failed");

                }
               

            }
            Console.ReadKey();

            
        }
    }
}
