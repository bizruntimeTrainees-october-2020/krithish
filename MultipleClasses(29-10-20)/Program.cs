using System;

namespace Program7
{
    class Car
    {
        //CLASS MEMBERS
        public String name = "Mustang";
        public String color = "red";
        public int maxspeed = 250;
    }
    class Accessories
    {

    }
    class Bike//Multiple Classes
    {
        String name;
        String orgin;
        int maxspeed;

    
          static void Main(string[] args)
          {
            Car newObj = new Car();
            
            Console.WriteLine(newObj.color);
            Console.WriteLine(newObj.name);
            Console.WriteLine(newObj.maxspeed);
            Bike oneObj = new Bike();
            oneObj.name = "Duke";
            oneObj.orgin = "austria";
            oneObj.maxspeed = 250;
            Console.WriteLine(oneObj.name);
            Console.WriteLine(oneObj.orgin);
            Console.WriteLine(oneObj.maxspeed);
          } 
    }      
}
