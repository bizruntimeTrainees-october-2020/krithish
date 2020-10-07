using System;

namespace EventsDelegates
{
    class Numbers
    {
            
    //creating delegate names with return type
        public delegate void subnum(int a, int b);
        public delegate void mulnum(int x, int y, int z);
        public delegate void divnum(double p, double q);

        public delegate bool Check_True_Or_False(String name);


               public void sub(int a, int b)
        {
        Console.WriteLine(" SUBTRACTION OF 57 FROM 93 IS : " +  ( a-b));
            }
    public void mul(int x,int y, int z)// ACTION DELEGATE
    {
        Console.WriteLine(" MULTIPLICATION OF 6 OF 6 IS : "+ x * y * z); 
    }
        public void div(double p,double q)
        {
            Console.WriteLine(" DIVISION OF 102 BY 5 IS : " +p / q);
        }

        public static bool check(string name)//Action Delegate
        {
            if (name.Length < 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public class EventHandlingg
        {

        
       public static void Main()
        {
                
                //creating an object for main class which is named as Numbers
                Numbers obj = new Numbers();
            subnum obj1 = new subnum(obj.sub);
            mulnum obj2 = new mulnum(obj.mul);
            divnum obj3 = new divnum(obj.div);
            

            //passing the values to the methods
            obj1(93, 57);
            obj2(6, 6,8);
            obj3(102, 5);


            //Predicate delegate

            Predicate<string> val = check;
            Console.WriteLine(val("LOLOLOLOLOL"));

                ProcessBusiness bl = new ProcessBusiness();
                bl.ProcessCompleted += bl_ProcessCompleted; // register with an event
                bl.StartProcess();



            }

            public static void bl_ProcessCompleted()
            {
                Console.WriteLine("Process Completed!");
            }
        }

        public delegate void Notify();  // delegate

        public class ProcessBusiness
        {
            public event Notify ProcessCompleted; // event

            public void StartProcess() // EVENT HANDLER METHOD
            {
                Console.WriteLine("Process Started!");
                int f = 52;
                int g = 4;
                int o;
                int ans;
                o = f + g * f;
                ans =g+ o;
                Console.WriteLine(o);
                Console.WriteLine(ans);
                OnProcessCompleted();
            }


            protected virtual void OnProcessCompleted() // USED TO INDICATE THAT IT IS PRESENT ONLY INSIDE THE CLASS 
            {
                ProcessCompleted?.Invoke();   //This WILL CALL ALL THE EVENT HANDLER METHODS
            }
        }
    }

    }

     

