using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oopsconcept
{
    internal class Program
    {

        class bankaccount
        {
            private long accountnumber = 1343543534543;  // Private account number
            private double balance;  // Private balance

            // Deposit method takes amount as input
            public double Deposit(double amount)
            {
                if (amount > 0)
                {
                    balance += amount;
                    Console.WriteLine($"Deposited: ₹{amount:F2}");
                }
                else
                {
                    Console.WriteLine("Nice try! But you can't deposit *nothing*. Even your piggy bank is laughing at you. HHHaaaHHH!");
                }

                return balance;
            }

            // GetBalance just returns the balance
            public double GetBalance()
            {
                Console.WriteLine("yoooooooooooooooo youuuu rich! gimme 20 bucks bro!");
                return balance;
            }
        }

        class animal
        {//mind it , "virtual" key word is important for the method to be overridden in the child class!
            public virtual void action() //virtual method to be overridden in the child class
            //if you pland to override this method .i.e u plan to redefine the same function in another child class, remember the "virtual" keyword!!       
            {
                Console.WriteLine("Animal is doing something!");
            }

        }
        class Cat: animal
        {
            public override void action() //overriding the method of the parent class
            //dont forget to use the "override" keyword to redefine the method of the parent class
            {    
                Console.WriteLine("Cat is trying to look cute!!!!");
            }
        }
        static void Main(string[] args)
        {
            bankaccount bakaca = new bankaccount();//declaring the object of the class
            string input = Console.ReadLine();

            if (double.TryParse(input, out double amount))
            {
                bakaca.Deposit(amount);
            }
            else
            {
                Console.WriteLine("Yo! That ain't a valid number. Try again.");
            }

            Console.WriteLine("Current Balance: ₹" + bakaca.GetBalance().ToString("F2"));
            Cat mycat= new Cat(); //creating an object of the Cat class
            mycat.action(); //calling the method of the parent class..i.e cat class can access the funtion of parent class
        }
    }
}
