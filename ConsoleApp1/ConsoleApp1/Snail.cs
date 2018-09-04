using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Snail : IAnimal
    {
        private string m_name;


        public string Species
        { get { return m_name; } }

        public Snail(string name)
        { name = m_name; }


        public void Speak()
        { Console.WriteLine("says nothing", m_name); }
    }
}
