using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Dog : IAnimal
    {
        private string m_name;


        public string Species
        { get { return m_name; } }

        public Dog(string name)
        { name = m_name; }

        
        public void Speak()
        { Console.WriteLine("{0} Bark", m_name); }
    }
}
