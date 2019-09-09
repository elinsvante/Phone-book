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
    /// Klass för att bearbeta kontakter i telefonboken phoneBook
    /// </summary>
    public class PhoneBook
    {    
        List<IContact> phoneBook = new List<IContact>();
        /// <summary>
        /// Lägga till kontakt i telefonboken
        /// </summary>
        /// <param name="contact"></param>
        public void Add(IContact contact)
        {          
            phoneBook.Add(contact);           
        }
        /// <summary>
        /// Ta bort kontakt i telefonboken
        /// </summary>
        /// <param name="contact"></param>
        public void Remove(IContact contact)
        {
            phoneBook.Remove(contact);
        } 
        /// <summary>
        /// Visa alla kontakter i telefonboken
        /// </summary>
        /// <returns></returns>
        public List<IContact> GetAll()
        {
            return phoneBook;
        }
    }
}
