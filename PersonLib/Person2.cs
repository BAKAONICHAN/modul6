using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLib
{
    public static class Person2

    {
        public static void Show(this Person person)
        {
            Console.WriteLine("{0} {1}", person.Name, person.Surname);
        }
    }
}