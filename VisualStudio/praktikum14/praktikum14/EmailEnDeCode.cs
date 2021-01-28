using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikum14
{
    class EmailEnDeCode
    {
        public void DecodeAccount(string account)
        {
            string[] arr;
            string domain = null;
            string fullName = null;

            if (account.Contains('@'))
            {
                arr = account.Split('@');
                domain = arr[1];
                fullName = arr[0];
            }
            else if (account.Contains('\\'))
            {
                if(account.Contains('|'))
                {
                    account = account.Split('|')[1];
                }
                arr = account.Split('\\');
                domain = arr[0];
                fullName = arr[1];
            }

            if (fullName.Contains('.'))
            {
                arr = fullName.Split('.');
                fullName = null;
                foreach (string a in arr)
                {
                    fullName += UppercaseFirst(a) + ' ';
                }
            }
            else
                fullName = UppercaseFirst(fullName);

            Console.WriteLine("Name: {1} * Domain: {0}\n", domain.Split('.')[0].ToUpper(), fullName);
        }

        public void EncodeAccount(string data)
        {
            string[] arr = data.Split(' ');
            string domain = arr[0].ToLower();
            string name = null;
            if (arr.Count() > 2)
                for (int n = 1; n < arr.Count(); n++)
                {
                    if (n == arr.Count() - 1)
                        name += '.' + arr[n].ToLower();
                    else
                        name += arr[n].ToLower();
                }
            else
                name = arr[1].ToLower();

            Console.Write("{0}@{1}, ",name, domain);
            Console.WriteLine("{0}\\{1}", domain.Split('.')[0], name);
        }

        private string UppercaseFirst(string toUpper)
        {
            if (string.IsNullOrEmpty(toUpper))
            {
                return string.Empty;
            }
            return char.ToUpper(toUpper[0]) + toUpper.Substring(1);
        }
    }


}
