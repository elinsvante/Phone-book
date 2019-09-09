
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Labb3 v.44
// Elin Svantesson
// Verision 1.0 2017-11-15

namespace SvantessonElin_Lab3
{
    /// <summary>
    /// Klass som hanterar hemliga kontakter
    /// </summary>
    class SecretContact : Contact
    {
        //Konstruktor
        public SecretContact(string förnamn, string efternamn, string telefonnummer) : base(förnamn, efternamn, telefonnummer)
        {
        }

        /// <summary>
        /// Overridning av ToString() som modifierar hur kontakten ska visas i listan om kontakten är hemlig
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return LastName + ", " + FirstName + ", " + "XXX-XXX XX XX";
        }
    }
}
