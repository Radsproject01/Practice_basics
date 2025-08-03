using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {  /*//this is a comment
            int x = 20;         //variable of int type declared and given value 20
            int y = 30;
            int z = x + y; //adding two variables and storing the result in a third variable
            Console.WriteLine("The sum of " + x + " and " + y + " is: " + z); //output the result to the console

            string name = "John"; //string variable declared and initialized
            Console.WriteLine("Hello, " + name + "!"); //output  the variable to the console
            //notice we are merging the message with the variable for output

            string lastname = "Doe"; //another string variable
            string fullname = name + " " + lastname; //concatenating two strings
            Console.WriteLine("Full name: " + fullname); //output the full name

            string strone = "Hello"; //string variable
            string strtwo = "World"; //another string variable
            string strthree = String.Concat(strone, " ", strtwo); //concatenating two strings with a space in between
            Console.WriteLine(strthree); //output the concatenated string
            string strfour = $"{strone} {strtwo}"; //using string interpolation to concatenate strings

            Console.WriteLine(strfour); //output the interpolated string

            string stranimal = "Dog"; //string variable
            Console.WriteLine(stranimal[0]); //output the first character of the string = D
            Console.WriteLine(stranimal[1]); //output the second character of the string = o
            Console.WriteLine(stranimal[2]); //output the third character of the string = g
            Console.WriteLine(stranimal.Length); //output the length of the string = 3
            Console.WriteLine(stranimal.ToUpper()); //output the string in uppercase = DOG
            Console.WriteLine(stranimal.ToLower()); //output the string in lowercase = dog
            Console.WriteLine(stranimal.Contains("o")); //check if the string contains the character 'o' = True
            Console.WriteLine(stranimal.IndexOf("o")); //output the index of the character 'o' in the string = 1
            Console.WriteLine(stranimal.IndexOf("z")); //output the index of the character 'z' in the string = -1 (not found)


            string sentence = "Welcome to C# programming";
            int startfrom = sentence.IndexOf("C#"); //find the index of the character 't' in the string
            Console.WriteLine("Index of 'C#': " + startfrom); //output the index of the character 't' in the string
            string substr = sentence.Substring(startfrom); //extract a substring starting from the index of 'C#'
            Console.WriteLine("Substring from 'C#': " + substr); //output the substring

            // string aboutjohn = "He is the so called "hunk" of the class"; //this will cause a compile error due to the use of double quotes inside a string
            // Console.WriteLine(aboutjohn); //error: Unterminated string literal
            string aboutjohnfixed = "He is the so called \"hunk\" of the class"; //fixing the error by escaping the double quotes
            string saysth = "it\'s a beautiful day"; //using single quotes to avoid escaping double quotes
            Console.WriteLine(saysth); //output the string with single quotes
            string txt = "The character \\ is called backslash.";
            Console.WriteLine(txt); //output the string with backslash
            string escpstr = "there were lots of errors\ni fixed them! ";
            Console.WriteLine(escpstr); //output the string with escape characters

            while (x < 23) //a simple while loop
            {
                Console.WriteLine("x is less than 23, current value of x: " + x);
                x++; //incrementing x by 1
            }
            int i = 0;
            do
            {
                Console.WriteLine(i);  //do - print the first value of i anyways
                i++;   //increment i by 1 
            }
            while (i < 5); //now check if after i is incemrented
                           //to one is it still <5 or grater that 5...
                           //keep going till becomes greater that 5

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string strcri in cars)
            {
                Console.WriteLine(strcri); //foreach loop to iterate through the array of cars to print each car name
                for (int it = 0; it < 10; it++)
                {
                    if (it == 4)
                    {
                        continue; // when it becaem 4 ; it sikkpe the writeline part 
                        //and goes to the next iteration
                        //it's like don't print if it's 4 just continue with 5
                    }
                    Console.WriteLine(it);  //skipping the number 4
                }

            }

            string[] strarcars = { "audi", "Bugatti", "BMW", "Mercedes", "Ford" }; //array of car names
            strarcars[0] = "Tesla"; //changing the first element of the array to "Tesla"
            for (int j = 0; j < strarcars.Length; j++) //iterating through the array of car names
            {
                Console.WriteLine(strarcars[j]); //printing each car name from the array but it will print tesla instead of audi
            }





            int[] intvalue = { 1, 2, 3, 4, 5 }; //array of integer values 
            //it goes something like this: 0th index has 1, 1st index has 2, 2nd index has 3, 3rd index has 4, and 4th index has 5
            //total 5 elements in the array
            for (int k = 0; k < 5; k++)  //so in array of 5 elements, the index starts from 0 and goes to 4
            {
                Console.WriteLine(intvalue[k]); //printing each car name from the array
            }

            string[] stkar = new string[9];

            stkar = new string[] { "BMW", "Ford", "Mazda", "BMW", "Ford", "Mazda" };
            // stkar[0] =  "volvo" ;
            ;//reassigning the array to a new array of car names
            for (int a = 0; a < stkar.Length; a++)
            {
                Console.WriteLine(stkar[a]); //printing each car name from the new array
            }


            double[] jk = { 1.4318863, 12, 45, 23.4564, 56, 28.3, 4689.8653 };
            Array.Sort(jk);  //in case of int array or any numeric array it will sort in ascending order
            for (int b = 0; b < jk.Length; b++)  //indeices are always integers!never any other type !!
            {
                Console.WriteLine(jk[b]); //printing each integer value from the sorted array
            }

            String[] starlight = { "Light", "Star", "Clouds", "Moon", "Sun", "Sky", "Earth", "Mars", "Venus" };
            Array.Sort(starlight); //sorting the string array in alphabetical order
            for (int b = 0; b < starlight.Length; b++)  //indeices are always integers!never any other type !!
            {
                Console.WriteLine(starlight[b]); //printing each integer value from the sorted array
            }

            int[,,] arr = {
                { //this is the 0th depth of the 3d array  the entire 1 bracket has 3- {},{},{} within it !
                    { 1, 12, 36 },
                    { 4, 51, 6 },
                    { 4, 45, 34 }
                },
                {//this is the 1st depth of the 3d array  the entire 1 bracket has 3- {},{},{} within it !
                    { 7, 8, 9 },
                    { 10, 11, 12 },
                    { 13, 14, 15 }
                }//line this we form 3d array


            };
            Console.WriteLine(arr[1, 2, 1]);
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int clm = 0; clm < arr.GetLength(1); clm++)
                {

                    for (int wid = 0; wid < arr.GetLength(2); wid++)
                    {
                        Console.WriteLine(arr[row, clm, wid]);
                    }

                }


            }


            string[] lyrics = { "Twinkle", "twinkle", "little", "star", "How", "I", "wonder", "what", "you", "are" };
            foreach (string word in lyrics) //foreach loop to iterate through the array of lyrics
            {
                Console.Write(word+" "); //printing each word from the array of lyrics
            }
            Console.WriteLine();//why this line is needed? because we want to print the next output in a new line
            int n=10,m=20, l=30; //declaring and initializing three integer variables   
            finddayungest(r:m, t: l, o: n); //calling the method to find the youngest child with named arguments
            IwillPrint(); //calling the method without any argument, it will use the default value "Noreway"

            //Method overloading example
            int myNum1 = PlusMethod(8, 5);
            double myNum2 = PlusMethod(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);










        }
        static void IwillPrint(string stcharter = "Noreway") //method with a default parameter value
        {
            Console.WriteLine(stcharter); //printing the string passed to the method
                                          //return stcharter;                 //return stcharter; //returning the string
        }
           static void finddayungest(int r, int t, int o) //method to find the youngest child
        {
            if (r < t && r <o)
            {
                Console.WriteLine("Child 1 is the youngest.");
            }
            else if (t < r && t < o)
            {
                Console.WriteLine("Child 2 is the youngest.");
            }
            else
            {
                Console.WriteLine("Child 3 is the youngest.");
            }

        
        }
        //method overloading example
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }



    }*/

            //for (; ; )
            //{
              //  Console.WriteLine("Hey! I am Trapped");
            //}//this is infinite loop.



                int? a = 5, b = 3,e=null, c = null;   // Binary: a = 0101, b = 0011
            Console.WriteLine($"Size of int:" + sizeof(int));//tells the sixe of the variable in bytes .

            c = (a > 3 & b > 2) ? a + b : a - b; //using ternary operator to check the condition and assign value to c
            Console.WriteLine($"Value of c: {c}" ); //output the value of c

            int d = e ?? 800; //using null-coalescing operator to assign value to d if c is null
            Console.WriteLine($"Value of c: {d}");
          /*  string mynull = null;
            mynull ??= "Default Value"; //using null-coalescing assignment operator to assign value to mynull if it is null
            console.WriteLine($"Value of mynull:" + mynull); //output the value of mynull
        not available in 7.3 version but works!!*/
            }
    }

}
