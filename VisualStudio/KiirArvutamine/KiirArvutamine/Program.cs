using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiirArvutamine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("    Start Game!\n1 - Liitmine & lahutamine\n2 - Korrutamine & jagamine\n3 - Kõik tehted\nX - Välju");
                string inP = Console.ReadLine();
                if (inP == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Liitmine ja Lahutamine!");
                    Run(1);
                }
                else if (inP == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Korrutamine ja Jagamine!");
                    Run(2);
                }
                else if (inP == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Kõik tehted segamini!");
                    Run(3);

                }
                else if (inP == "x" || inP == "X")
                {
                    Console.WriteLine("Tänud mängimast!");
                    Console.ReadLine();
                    run = false;
                }
                else
                {
                    Console.Clear();
                    ErrorRed("Vale sisend!");
                }

            }
        }

        static void Run(int s)
        {
            int score = 0;
            bool run = true;
            if (s == 1 && run == true)
            {
                while (run == true)
                {
                    run = AddSub();
                    if (run == true)
                    {
                        score+=1;
                    }
                }
            }
            else if (s == 2 && run == true)
            {
                while (run == true)
                {
                    run = MultDev();
                    if (run == true)
                    {
                        score+=1;
                    }
                }
            }
            else if (s == 3 && run == true)
            {
                while (run == true)
                {
                    run = All();
                    if (run == true)
                    {
                        score += 1;
                    }
                }
            }
            Console.WriteLine("Tulemus: " + score);
        }

        static bool AddSub()
        {
            bool run = true;
            Random rand = new Random();
            int c = rand.Next(100);
            if (c <= 50)
            {
                int arv1 = rand.Next(100);
                int arv2 = rand.Next(100);
                Console.Write("{0} + {1} = ", arv1, arv2);
                int ans = Num(Console.ReadLine());
                if (arv1 + arv2 == ans)
                {
                    Console.WriteLine("Õige!");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Vale! Proovi uuesti!");
                    run = false;
                }
            }
            else if (c > 50)
            {
                int arv1 = rand.Next(100);
                int arv2 = rand.Next(100);
                Console.Write("{0} - {1} = ", arv1, arv2);
                int ans = Num(Console.ReadLine());
                if (arv1 - arv2 == ans)
                {
                    Console.WriteLine("Õige!");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Vale! Proovi uuesti!");
                    run = false;
                }
            }
            return run;
        }

        static bool MultDev()
        {
            bool run = true;
            Random rand = new Random();
            int c = rand.Next(100);
            if (c <= 50)
            {
                int arv1 = rand.Next(12);
                int arv2 = rand.Next(12);
                Console.Write("{0} * {1} = ", arv1, arv2);
                int ans = Num(Console.ReadLine());
                if (arv1 * arv2 == ans)
                {
                    Console.WriteLine("Õige");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Vale! Proovi uuesti!");
                    run = false;
                }
            }
            else if (c > 50)
            {
                int arv1 = rand.Next(100);
                int arv2 = rand.Next(1,100);
                while(arv1 % arv2 != 0)
                {
                    arv1 = rand.Next(100);
                    arv2 = rand.Next(1,100);
                }
                Console.Write("{0} / {1} = ", arv1, arv2);
                int ans = Num(Console.ReadLine());
                if (arv1 / arv2 == ans)
                {
                    Console.WriteLine("Õige!");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Vale! Proovi uuesti!");
                    run = false;
                }
            }
            return run;
        }

        static bool All()
        {
            bool run = true;
            Random rand = new Random();
            int c = rand.Next(100);
            if (c <= 25)
            {
                int arv1 = rand.Next(12);
                int arv2 = rand.Next(12);
                Console.Write("{0} * {1} = ", arv1, arv2);
                int ans = Num(Console.ReadLine());
                if (arv1 * arv2 == ans)
                {
                    Console.WriteLine("Õige!");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Vale! Proovi uuesti!");
                    run = false;
                }
            }
            else if (c <= 50)
            {
                int arv1 = rand.Next(100);
                int arv2 = rand.Next(1,100);
                while (arv1 % arv2 != 0)
                {
                    arv1 = rand.Next(100);
                    arv2 = rand.Next(1,100);
                }
                Console.Write("{0} / {1} = ", arv1, arv2);
                int ans = Num(Console.ReadLine());
                if (arv1 / arv2 == ans)
                {
                    Console.WriteLine("Õige!");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Vale! Proovi uuesti!");
                    run = false;
                }
            }
            else if (c <= 75)
            {
                int arv1 = rand.Next(100);
                int arv2 = rand.Next(100);
                Console.Write("{0} + {1} = ", arv1, arv2);
                int ans = Num(Console.ReadLine());
                if (arv1 + arv2 == ans)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Incorrect!");
                    run = false;
                }
            }
            else if (c <= 100)
            {
                int arv1 = rand.Next(100);
                int arv2 = rand.Next(100);
                Console.Write("{0} - {1} = ", arv1, arv2);
                int ans = Num(Console.ReadLine());
                if (arv1 - arv2 == ans)
                {
                    Console.WriteLine("Õige!");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Vale! Proovi uuesti!");
                    run = false;
                }
            }
            return run;
        }

        static int Num(string isNum)
        {
            int num = 0;
            if (isNum != "")
            {
                if (isNum[0].ToString() == "-")
                {
                    string replacedString = isNum.Replace("-", "");
                    if (replacedString.All(char.IsDigit) == true && replacedString.Length < 9)
                    {
                        num = Int32.Parse(replacedString) *-1;
                    }
                }
                else
                {
                    if (isNum.All(char.IsDigit) == true && isNum.Length < 9)
                    {
                        num = Int32.Parse(isNum);
                    }
                }

            }
            return num;
        }

        static void ErrorRed(string printRed)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(printRed);
            Console.ForegroundColor = ConsoleColor.Cyan;
        }

        public int OnlyInt(string stringNumber) //Tegin endale string to int printeri. Ei leidnud süsteemi poolt loodud meetodit selleks. VB on olemas - tunnis küsin!
        {
            int num = 0;
            if (stringNumber.All(char.IsDigit) == true && stringNumber != "" && stringNumber.Length < 9)
            {
                num = Int32.Parse(stringNumber);  //Ainuke Int Väärtuse tekitaja. Kõik väärtused "stringis".
            }
            else if (stringNumber == "")
            {
                ErrorRed("Thanks for Nothing!"); //Vabandan väikese naljanumbri pärast! :)     Little EasterEgg Included!
            }
            else
            {
                ErrorRed("Input includes non-numberic characters!");
            }
            return num; //Kui String väärtus ei ole numbriline, siis väljund alati 0.
        }

    }
}
