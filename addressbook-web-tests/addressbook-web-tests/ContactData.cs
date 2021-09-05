using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook_web_tests
{
    class ContactData
    {
        private string firstName;
        private string lastName;
        private string middleName;
        private string nickName;
        private string title;
        private string company;
        private string address;
        private string address2;
        private string homePhone;
        private string mobilePhone;
        private string workPhone;
        private string fax;
        private string phone2;
        private string email;
        private string email2;
        private string email3;
        private string contactHomePage;
        private string birthDay;
        private string Anniversary;
        private string notes;

        public ContactData(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string MiddleName { get => middleName; set => middleName = value; }
        public string NickName { get => nickName; set => nickName = value; }
        public string Title { get => title; set => title = value; }
        public string Company { get => company; set => company = value; }
        public string Address { get => address; set => address = value; }
        public string Address2 { get => address2; set => address2 = value; }
        public string HomePhone { get => homePhone; set => homePhone = value; }
        public string MobilePhone { get => mobilePhone; set => mobilePhone = value; }
        public string WorkPhone { get => workPhone; set => workPhone = value; }
        public string Fax { get => fax; set => fax = value; }
        public string Phone2 { get => phone2; set => phone2 = value; }
        public string Email { get => email; set => email = value; }
        public string Email2 { get => email2; set => email2 = value; }
        public string Email3 { get => email3; set => email3 = value; }
        public string ContactHomePage { get => contactHomePage; set => contactHomePage = value; }
        public string BirthDay { get => birthDay; set => birthDay = value; }
        public string Anniversary1 { get => Anniversary; set => Anniversary = value; }
        public string Notes { get => notes; set => notes = value; }
    }
}
