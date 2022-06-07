using System.Collections.Generic;
using System.Linq;

namespace BirdsList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>();
            {
                new Duck() { Kind = KindOfDuck.krzyżówka, Size = 43 };
                new Duck() { Kind = KindOfDuck.piżmowa, Size = 45 };
                new Duck() { Kind = KindOfDuck.nur, Size = 35 };
                new Duck() { Kind = KindOfDuck.piżmowa, Size = 27 };
                new Duck() { Kind = KindOfDuck.krzyżówka, Size = 35 };
                new Duck() { Kind = KindOfDuck.nur, Size = 33 };
            }

            IEnumerable<Bird> upcastDucks = ducks;
            Bird.FlyAway(upcastDucks.ToList(), "Minnesota");
        }
    }
}