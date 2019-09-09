
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Labb2 v.44
// Elin Svantesson
// Verision 1.0 2017-11-15

namespace SvantessonElin_Lab3
{
    public partial class Form1 : Form
    {
        PhoneBook book;

        //Konstruktor
        public Form1()
        {
            InitializeComponent();
            book = new PhoneBook();
        }

        private void btnSaveContact_Click(object sender, EventArgs e)
        {

            string[] inmatat = txtNewContact.Text.Split(',');
            
            if (inmatat.Length == 3)
            {
                if (chkIsSecret.Checked)
                {    
                    SecretContact secretContact = new SecretContact(inmatat[0], inmatat[1], inmatat[2]);
                    book.Add(secretContact);
                    PrintContacts();
                }
                else
                {
                    Contact normalContact = new Contact(inmatat[0], inmatat[1], inmatat[2]);
                    book.Add(normalContact);
                    PrintContacts();
                }
            }
            else
            {
                MessageBox.Show("Din inmatning är inkorrekt!");
            }
        }

        private void lstContacts_SelectedIndexChanged(object sender, EventArgs e)
        {        
            IContact currentperson = (IContact)lstContacts.SelectedItem;
            if (currentperson != null)
            { 
                txtFirstName.Text = currentperson.FirstName;
                txtLastName.Text = currentperson.LastName;
                txtPhoneNumber.Text = currentperson.PhoneNumber;
            }
       
        }

        private void E(object sender, EventArgs e)
        {

        }

        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            IContact contact = (IContact)lstContacts.SelectedItem;
            book.Remove(contact);
            PrintContacts();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhoneNumber.Clear();
        }

        /// <summary>
        /// Metod för att först tömma listan och sedan lägga in alla kontakter igen (uppdatering av listan)
        /// </summary>
        public void PrintContacts()
        {
            lstContacts.Items.Clear();
            List<IContact> allContacts = book.GetAll();
            for (int i = 0; i < allContacts.Count; i++)
            {
                lstContacts.Items.Add(allContacts[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
    }
}
