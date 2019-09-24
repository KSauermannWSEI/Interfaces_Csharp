using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        //const string x = "x";
        //readonly string y;
        static void Main(string[] args)
        {
            //List<Person> names = new List<Person>
            //{
            //   new Person{ Name= "A" },
            //   new Person{ Name= "b" },
            //   new Person{ Name= "r" },
            //   new Person{ Name= "t" },
            //   new Person{ Name= "e" }                
            //};
            //foreach (var item in names)
            //{
            //    names.Remove(item);
            //    Console.WriteLine(item.Name);
            //}
            //wer 1
            Person person = new Person();
            person.Name = "1";
            try
            {
                Console.WriteLine(person.Name);
            }
            finally
            {
                person.Dispose();
            }

            //wer 2
            using (Person person2 = new Person())
            {
                person.Name = "2";
                Console.WriteLine(person.Name);
            }

            Console.Read();
        }
    }
}
