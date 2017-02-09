using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HengiloregisderiApplication
{
    class Perssons
    {
        private List<Persson> perssons;
        public Perssons()
        {
            perssons = new List<Persson>();
        }
        /// <summary>
        /// Add person to collection
        /// </summary>
        /// <param name="persson">Person to add</param>
        public void AddPersson(Persson persson)
        {
            perssons.Add(persson);
        }
        /// <summary>
        /// Return a person to caller application
        /// </summary>
        /// <param name="index">index i collection</param>
        /// <returns>person object or null</returns>
        public Persson GetPersson(int index)
        {
            if (index < perssons.Count) return perssons.ElementAt(index);
            else return null;

        }
        public Persson findPersson(string Sotu)
        {
            foreach(Persson persson in perssons)
            {
                if (Sotu.Equals(persson.Sotu))
                {
                    return persson;
                }
            }
            // no person with that sotu... :(
            return null;
        }
        public void PrintCollection()
        {
            foreach(Persson persson in perssons)
            {
                Console.WriteLine(persson.ToString());
            }
        }
    }
}
