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
            private long accountnumber = 1343543534543;  //this can not be accessed! no one can know what's the number and amount
            private double balance = 10000.00;
            public void deposite(double amount)
            {
                if (amount > 0)
                {
                    balance += amount;
                    Console.WriteLine("Deposited: " + amount);

                    /*you definitely have to have amount gereater than 0 to make a deposite
                    //otherwise , you broke homie...you a cinderella!
                    Better start cleaning to earn dat allowance!!*/
                }
                else
                {
                    Console.WriteLine("Nice try! But you can't deposit *nothing*. Even your piggy bank is laughing at you. HHHaaaHHH!");

                }
            }
            public double GetBalance()
            {
                return balance;
            }
        }

        class animal
        {
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
            bakaca.deposite(0.00); //calling the method to deposite amount
            Console.WriteLine("The current balace is  " + bakaca.GetBalance());  // Safe access
            Cat mycat= new Cat(); //creating an object of the Cat class
            mycat.action(); //calling the method of the parent class..i.e cat class can access the funtion of parent class
        }
    }
}
