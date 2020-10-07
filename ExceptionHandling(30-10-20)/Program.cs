using System;


namespace ExceptionHandling
{
    class Numbers    //class created 
    {
    public    static void checkAge(int age)// method 
        {
            if (age < 18)
            {
                throw  new Exception("Access denied = must be atleast 18+");// user defined expection==Our own exception
            }
            else
            {
                Console.WriteLine("Access Granted");
            }
        }
        public static void carQuality(String quality)
        {
            if (quality == "damaged")
            {
                throw new Exception("Access denied becuase car is damaged ");

            }
            else
            {
                Console.WriteLine("Car can be Taken ");
            }
           
        }
       
        static void Main(string[] args)
        {

            try //try block where expection might occur
            {
              
                int a = 12;
                int b = 52;
                int  c = a / b;
           
                                      
           }
            catch // catch block specifies the type of exception
            {
                Console.WriteLine("divide by zero error ");
            }

           
          
            finally // wheter exception is present or not  this block will get executed 
            {
                int[] myNumbers = { 1, 2, 3, 4 }; // array of numbers 
                Console.WriteLine("index number of 2 is :"+myNumbers[2]); // print statement
                Console.WriteLine("Code has been executed...Thank you "); // print statement
                checkAge(25);// we have created the checkage method at starting of the program input is given here
                carQuality(" not damaged");
            }
          

        }
    }
}
