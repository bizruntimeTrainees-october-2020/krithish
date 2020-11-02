using System;
using System.Collections.Generic;
using System.Text;
using System.Reactive.Linq;


namespace ReactiveOperators
{
    class Delayy
    {
        public void DelayMethod()
        {
            var oneNumberEveryFiveSeconds = Observable.Interval(TimeSpan.FromSeconds(5));

            // Instant echo
            oneNumberEveryFiveSeconds.Subscribe(num =>
            {
                Console.WriteLine(num);
            });

            // One second delay
            oneNumberEveryFiveSeconds.Delay(TimeSpan.FromSeconds(1)).Subscribe(num =>
            {
                Console.WriteLine("...{0}...", num);
            });

            // Two second delay
            oneNumberEveryFiveSeconds.Delay(TimeSpan.FromSeconds(2)).Subscribe(num =>
            {
                Console.WriteLine("......{0}......", num);
            });

            Console.ReadKey();

        }
    }
}
