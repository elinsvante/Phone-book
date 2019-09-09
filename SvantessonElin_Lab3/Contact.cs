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
    /// Klass som skapar kontakter utifrån användarens input
    /// </summary>
    public class Contact : IContact
    {
        //Egenskaper som inte går att tilldela utifrån klassen
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string PhoneNumber { get; private set; }

        //Konstruktor
        public Contact(string förnamn, string efternamn, string telefonnummer)
        {                          
            FirstName = förnamn;
            LastName = efternamn;
            PhoneNumber = telefonnummer;                     
        }
        
        //override av default metoden ToString() för att ändra på hur kontakten visas i listan
        public override string ToString()
        {
            return LastName + ", " + FirstName + ", " + PhoneNumber;
        }
     
    }

    //interface som ett kontrakt som visar vad som ska finnas med i klassen om man ärver från det
    public interface IContact
    {
        string FirstName { get; }
        string LastName { get; }
        string PhoneNumber { get; }
    }
}
