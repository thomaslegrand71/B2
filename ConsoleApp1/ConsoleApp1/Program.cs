using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<IAnimal> Pets = new List<IAnimal>();

            Dog Milou = new Dog("Milou");
            Dog Rintintin = new Dog("Rintintin");
            Human MissPatate = new Human("Miss Patate");
            Human Jojo = new Human("Jojo");
            Human TomTom = new Human("TomTom");
            Snail Mute = new Snail("Mute");

            Pets.Add(Milou);
            Pets.Add(Rintintin);
            Pets.Add(MissPatate);
            Pets.Add(Jojo);
            Pets.Add(TomTom);
            Pets.Add(Mute);

            foreach (IAnimal x in Pets)
            { x.Speak(); }

            Console.ReadLine();

        }
    }
}
