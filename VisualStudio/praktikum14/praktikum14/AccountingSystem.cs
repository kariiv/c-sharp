using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace praktikum14
{
    class AccountingSystem
    {
        List<int> date = new List<int>();
        List<int> amount = new List<int>();
        List<string> description = new List<string>();
        List<string> category = new List<string>();
        public void Account()
        {
            bool run = true;
            while (run)
            {
                Console.Clear();
                Console.Write("Household Accounts\n1) Add data.\n2) View all data.\n3) Search data.\n4) Modify data.\n5) Delete data.\n6) Sort alphabetically\n7) Fix spaces.\n8) View filtred data.\nX) - Exit\nOption: ");
                string inP = Console.ReadLine();
                if (inP == "1")
                    AddData();
                else if (inP == "2")
                    ViewAllData();
                else if (inP == "3")
                    SearchData();
                else if (inP == "4")
                    ModifyData();
                else if (inP == "5")
                    DeleteData();
                else if (inP == "6")
                    SortAlphabet();
                else if (inP == "7")
                    FixSpaces();
                else if (inP == "8")
                    ViewFilteredData();
                else if (inP == "X" || inP == "x")
                    run = false;
                else
                    Console.WriteLine("Invalid input");
            }
            Console.Clear();
            Console.WriteLine("GoodBye");
            Thread.Sleep(1500);
        }

        private void AddData()
        {
            Console.Write("Enter date (DDMMYYYY): ");
            string day = Console.ReadLine();
            while (!day.All(Char.IsDigit) || day.Length != 8)
                day = Console.ReadLine();
            date.Add(Int32.Parse(day));

            Console.Write("Enter description: ");
            string descript = Console.ReadLine();
            while (String.IsNullOrEmpty(descript))
                descript = Console.ReadLine();
            description.Add(descript);

            Console.Write("Enter category: ");
            string cat = Console.ReadLine();
            while (String.IsNullOrEmpty(cat))
                cat = Console.ReadLine();
            category.Add(cat);

            Console.Write("Enter amount: ");
            string money = Console.ReadLine();
            while (String.IsNullOrEmpty(money))
                    money = Console.ReadLine();
            amount.Add(Int32.Parse(money));
        }

        private void ViewAllData()
        {
            for (int n = 0; n < date.Count; n++)
            {
                Console.WriteLine("{0}. {1} * {2} * ({3}) * {4}", n+1, DateEncoder(date[n]), description[n], category[n], amount[n]);
            }
            Console.Write("\nClick ENTER to continue...");
            Console.ReadLine();
        }
        private string DateEncoder(int date)
        {
            string dateString;
            if (date < 10000000)
                dateString = "0" + date.ToString().Substring(0, 1) + "/" + date.ToString().Substring(1, 2) + "/" + date.ToString().Substring(3, 4);
            else
                dateString = date.ToString().Substring(0, 2) + "/" + date.ToString().Substring(2, 2) + "/" + date.ToString().Substring(4, 4);
            return dateString;
        }

        private void SearchData()
        {
            Console.Write("Enter the string: ");
            string InpString = Console.ReadLine().ToLower();
            Console.Write("Results: ");
            bool result = false;
            for(int n = 0; n < description.Count;n++)
            {
                if (description[n].ToLower().Contains(InpString))
                {
                    Console.Write((n + 1) + ", ");
                    result = true;
                }
                else if (category[n].ToLower().Contains(InpString))
                {
                    Console.Write((n + 1) + ", ");
                    result = true;
                }
                if (!result)
                    Console.Write("no matches found.");
            }
            Console.Write("\nClick ENTER to continue...");
            Console.ReadLine();
        }

        private void ModifyData()
        {
            Console.Write("Enter the record number: ");
            int record = Int16.Parse(Console.ReadLine()) - 1;

            Console.Write("Date (Was {0}; hit ENTER to leave as is): ", date[record]);
            string inP = Console.ReadLine();
            if (!String.IsNullOrEmpty(inP))
            {
                while (!inP.All(Char.IsDigit) || inP.Length != 8)
                    inP = Console.ReadLine();
                date[record] = Int32.Parse(inP);
            }

            Console.Write("Description (Was {0}; hit ENTER to leave as is): ", description[record]);
            inP = Console.ReadLine();
            if (!String.IsNullOrEmpty(inP))
            {
                while (String.IsNullOrEmpty(inP))
                    inP = Console.ReadLine();
                description[record] = inP;
            }

            Console.Write("Category (Was {0}; hit ENTER to leave as is): ", category[record]);
            inP = Console.ReadLine();
            {
                while (String.IsNullOrEmpty(inP))
                    inP = Console.ReadLine();
                category[record] = inP;
            }

            Console.Write("Amount (Was {0}; hit ENTER to leave as is): ", amount[record]);
            inP = Console.ReadLine();
            {
                while (String.IsNullOrEmpty(inP))
                    inP = Console.ReadLine();
                amount[record] = Int32.Parse(inP);
                inP = inP.Trim();
            }
        }

        private void DeleteData()
        {
            Console.Write("Enter the record number: ");
            int record = Int16.Parse(Console.ReadLine());

            date.RemoveAt(record);
            description.RemoveAt(record);
            category.RemoveAt(record);
            amount.RemoveAt(record);
        }

        private void SortAlphabet()
        {
            for (int a = 1; a < date.Count - 1; a++)
                for (int b = a; b >= 0; b--)
                {
                    int date1, date2;

                    if(date[b].ToString().Length == 7)
                        date1 = Int32.Parse(date[b].ToString().Substring(3, 4) + date[b].ToString().Substring(1, 2) + date[b].ToString().Substring(0, 1));
                    else
                        date1 = Int32.Parse(date[b].ToString().Substring(4, 4) + date[b].ToString().Substring(2, 2) + date[b].ToString().Substring(0, 2));

                    if(date[b + 1].ToString().Length == 7)
                        date2 = Int32.Parse(date[b + 1].ToString().Substring(3, 4) + date[b + 1].ToString().Substring(1, 2) + date[b + 1].ToString().Substring(0, 1));
                    else
                        date2 = Int32.Parse(date[b + 1].ToString().Substring(4, 4) + date[b+1].ToString().Substring(2, 2) + date[b + 1].ToString().Substring(0, 2));

                    if (date1 > date2)
                    {
                        MoveData(b);
                    }
                    else if(date1 == date2 && String.Compare(description[b], description[b+1]) == 1)
                    {
                        MoveData(b);
                    }
                }
        }

        private void MoveData(int b)
        {
            int tempDate = date[b];
            int tempAmount = amount[b];
            string tempDesc = description[b];
            string tempCat = category[b];

            date[b] = date[b + 1];
            amount[b] = amount[b + 1];
            description[b] = description[b + 1];
            category[b] = category[b + 1];

            date[b + 1] = tempDate;
            amount[b + 1] = tempAmount;
            description[b + 1] = tempDesc;
            category[b + 1] = tempCat;
        }

        private void FixSpaces()
        {
            for (int n = 0; n < description.Count; n++)
            {
                string noSpaces = null;
                bool lastWasSpace = true;
                foreach (char e in description[n])
                {
                    if (e != ' ')
                    {
                        noSpaces += e;
                        lastWasSpace = false;
                    }
                    else if (e == ' ' && !lastWasSpace)
                    {
                        noSpaces += ' ';
                        lastWasSpace = true;
                    }
                }
                description[n] = noSpaces;
                description[n] = char.ToUpper(description[n][0]) + description[n].Substring(1).ToLower();
            }
        }

        private void ViewFilteredData()
        {
            int summary = 0;
            for (int n = 0; n < amount.Count; n++)
            {
                summary += amount[n]; 
            }
            Console.WriteLine();
            Console.Write("Expences: " + summary + "\nClick ENTER to continue...");
            Console.ReadLine();
        }
    }
}
