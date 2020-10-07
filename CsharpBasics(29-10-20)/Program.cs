using System;

namespace CsharpBasics
{
    class Basic
    {
       
        static void Main(string[] args)
        {

            //Variable  and Data Type Example
            Console.WriteLine("Varibale and Date Type Example ");
            int myNum = 15; // myNum is a VARIABLE  of DATATYPE int
            myNum = 20; //assigning a value to a variable
            Console.WriteLine(myNum); //displays output


            Console.WriteLine("Long Datatype Example");
            long myNum1 = 15000000000L; //USING DATATYPE LONG WE CAN STORE WHOLE NUMBBER 
            Console.WriteLine(myNum1);

            //bOOLEAN EXAMPLE
            Console.WriteLine("BOOLEAN EXAMPLE");

            bool isDogAnimal = true;
            bool isCrowAnimal = false;
            Console.WriteLine(isDogAnimal);   // Outputs True
            Console.WriteLine(isCrowAnimal);   // Outputs False

            //String  and character Example
            Console.WriteLine("STRING CONCATENATION AND CHARACTER EXAMPLE");

            string firstName = "Cristiano ";  //String 1
            string lastName = "Ronaldo";      //String 2
            string initial = "R";             //CHARACTER
            string fullName = firstName + lastName + initial; //Concatenation of Two Strings
            Console.WriteLine(fullName);

            //Decalaring Many Variables And Operators

            Console.WriteLine("Variables and Operators");
            int x = 5, y = 6, z = 50; //Declaring Variables
            Console.WriteLine(x + y + z); // here the variables uses '+' operator to sum the variables  
            Math.Max(x, z); // MAth operator to find max value 


            //Identifiers 
            Console.WriteLine("IDENTIFIER");
            int minsPerHour = 60; //Unique name here is minsPerHOur this is an identifier
            Console.WriteLine(minsPerHour);


            /*       TYPE CASTING 
             Conversions Using Built In METHODS*/

            Console.WriteLine("Type Casting Using Built In Methods");
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));    // Convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // Convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // Convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // Convert bool to string



            //GIVING USER INPUT 
            Console.WriteLine("Below is the Example for User Input");

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine()); //USED TO CONVERT BASE DATATYPE TO ANOTHER TYPE
            Console.WriteLine("Your age is: " + age);

        }
    }
}
