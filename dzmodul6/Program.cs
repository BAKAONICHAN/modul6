
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonLib;
using static System.Console;

namespace dzmodul6
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                Name = "Petr",
                Surname = "Nicolaevich"
            };
            Person2.Show(person);
            Colection collection = new Colection();
            collection.show();
            ReadLine();
        }
    }
}