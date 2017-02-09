using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HengiloregisderiApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a new Person objects
            Persson persson1 = new Persson
            {
                Firstname = "Sami",
                Lastname = "Saapas",
                Sotu = "123123-1337"
            };
            Persson persson2 = new Persson
            {
                Firstname = "Lasse",
                Lastname = "Lapanen",
                Sotu = "456456-1337"
            };
            Persson persson3 = new Persson
            {
                Firstname = "Katri",
                Lastname = "Korkokenka",
                Sotu = "789789-1337"
            };
            //create a persons object
            Perssons kaveri = new Perssons();
            //Add person object to persons collection
            kaveri.AddPersson(persson1);
            kaveri.AddPersson(persson2);
            kaveri.AddPersson(persson3);

            // get one person from persons collection
            Persson persson4 = kaveri.GetPersson(0);
            if (persson4 != null)
            {
                Console.WriteLine(persson4.ToString());
            }
            else
            {
                Console.WriteLine("Person not found in mun frendit");
            }
            kaveri.PrintCollection();

            string sotu = "123123-1337";
            Console.WriteLine("Find sotu: " + sotu);
            Persson persson5 = kaveri.findPersson(sotu);
            if (persson5 != null)
            {
                Console.WriteLine(persson5.ToString());

            }
            else
            {
                Console.WriteLine("EI OLE!!!");
            }
        }
    }
}
