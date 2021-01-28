using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    class EmployeeData
    {
        public List<string> email = new List<string>();
        public EmployeeData()
        {
            email.Add("andre.griffin@ou.eu");
            email.Add("john.snow@gt.eu");
            email.Add("tim-allen.toomingas@eu.eu");
            email.Add("hei-hoo.chee_choo@china.eu");
            email.Add("a.chin_chan@c.e");
        }

        public List<string> NameFromAddress() //for the List
        {
            List<string> names = new List<string>();
            string firstName = null;
            string lastName = null;

            foreach (string e in email)
            {
                lastName = null;
                if (e.Contains('@'))
                {
                    string fullName = RemoveDomain(e);
                    firstName = FirstNameCheckup(fullName);
                    lastName = LastNameCheckup(fullName);
                }
                else
                    firstName = "NoAddress";

                firstName += " " + lastName;
                names.Add(firstName);
            }

            return names;
        }
        public string NameFromAddress(string address) //For single address 
        {
            string firstName = null;
            string lastName = null;
            if (address.Contains('@'))
            {
                string fullName = RemoveDomain(address);
                firstName = FirstNameCheckup(fullName);
                lastName = LastNameCheckup(fullName);
            }
            else
                firstName = "NoAddress";

            firstName += " " + lastName;

            return firstName;
        }

        public string RemoveDomain(string input) //Removes only domain address
        {
            input = input.Substring(0, input.IndexOf('@'));
            return input;
        }

        //Takes only firstNames
        public string FirstNameCheckup(string name)
        {
            string subName = ""; //used only if there is second firstName.
            if(name.Contains('.')) //takes the first part to the dot. First name exists
                name = name[0].ToString().ToUpper() + name.Substring(1, name.IndexOf('.')-1); //firstName selection
            if (name.Contains('-')) //does name contains second name && if lastname is missing then it is first name.
            {
                subName = " " + name[name.IndexOf('-') + 1].ToString().ToUpper() + name.Substring(name.IndexOf('-') + 2, name.Length - name.IndexOf('-') - 2);
                name = name[0].ToString().ToUpper() + name.Substring(1, name.IndexOf('-')-1);
            }
            if (name.Length < 2)
                name = "Unknown";
            if (subName.Length < 2)
                subName = "";

            return name + subName; 
        }

        //Takes only lastNames
        public string LastNameCheckup(string name)
        {
            string subName = ""; //used only if there is second name.
            if (name.Contains('.')) //takes the first part to the dot. First name exists
                name = name[name.IndexOf('.')+1].ToString().ToUpper() + name.Substring(name.IndexOf('.') + 2, name.Length - 2 - name.IndexOf('.')); //firstName selection
            if (name.Contains('_')) //does name contains second name && if firstName is missing then it is second name.
            {
                subName = " " + name[name.IndexOf('_') + 1].ToString().ToUpper() + name.Substring(name.IndexOf('_') + 2, name.Length - name.IndexOf('_') - 2);
                name = name[0].ToString().ToUpper() + name.Substring(1, name.IndexOf('_')-1);
            }

            if (name.Length < 2)
                name = "Unknown";
            if (subName.Length < 2)
                subName = "";

            return name + subName;
        }
    }
}
