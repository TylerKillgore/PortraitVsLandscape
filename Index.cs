
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace ControlFlow1

{

    class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Please enter a number.");

            int numberOne;

            string inputOne = Console.ReadLine();

            int.TryParse(inputOne, out numberOne);

            

            Console.WriteLine("Please enter another number.");

            int numberTwo;

            string inputTwo = Console.ReadLine();

            int.TryParse(inputTwo, out numberTwo);



            if (numberOne > numberTwo)

            {

                Console.WriteLine(inputOne + " is greater!");

            }



            if (numberTwo > numberOne)

            {

                Console.WriteLine(inputTwo + " is greater!");

                Console.ReadLine();



            }

            if (numberOne == numberTwo)

            {

                Console.WriteLine(numberOne + " and " + numberTwo + " are equal!");

                Console.ReadLine();

            }

         

            }

        }

    }
