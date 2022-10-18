using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    internal class Person
    {
        public string _FullName = "Andry";
        public int _Age = 21;
        public void Move()
        {
            Console.WriteLine($"{_FullName} сделал шаг");
        }
        public void Talk()
        {
            Console.WriteLine($"{_FullName} говорит - Ананас");
        }
    }
}
