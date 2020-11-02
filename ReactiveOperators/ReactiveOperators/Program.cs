using System;

namespace ReactiveOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Simple sim = new Simple();
            sim.SimpleMethod();
            sim.Range();

            //Delayy d = new Delayy();
            //d.DelayMethod();

            //Sharing c = new Sharing();
            //c.Shared();
        }
    }
}
