using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace HomeWork5 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan; // My Default color :D

            bool run = true;
            TV TVremote = new TV(); //Ex5.
            Console.WriteLine("Ex5.\nTV is turned off!");
            while(run == true)
            {
                Console.WriteLine("TV Remote:\n0) On/Off\n1) Vol. +\n2) Vol. -\n3) Channel +\n4) Channel - \nX) Exit TVremote");
                string InP = Console.ReadLine();
                if (InP == "X" || InP == "x")
                {
                    Console.Clear();
                    run = false;
                }
                else if (InP.All(Char.IsDigit) && InP.Length <= 1 && InP != "")
                {
                    TVremote.System(OnlyInt(InP));
                }
                else
                {
                    Console.Clear();
                    ErrorRed("Invalid input!");
                }
            }

            Console.WriteLine("Ex4.");
            run = true; //Ex4.
            while (run == true)
            {
                Console.WriteLine("Insert amount of money < 1000\nX) Exit");
                string InP = Console.ReadLine();
                Console.Clear();
                if (InP == "X" || InP == "x")
                {
                    run = false;
                }
                else if (InP.All(char.IsDigit) == true)
                {
                    int e = OnlyInt(InP);
                    if(e.ToString().Length < 4 && e.ToString().Length > 0)
                    {
                        MoneyTeller(e);
                    }
                    else
                    {
                        ErrorRed("Only 1-999");
                    }
                }
                else
                {
                    ErrorRed("Invalid input!");
                }
            }
            Console.Clear();
            Console.Write("Ex3.\nMedian\nWrite a number of list of the length: "); //Ex3.
            int median = Median(OnlyInt(Console.ReadLine()));
            Console.Write("Median: " + median + "\n\nArithmetic mean\nWrite a number of list of the length: ");
            int arith = Arith(OnlyInt(Console.ReadLine()));
            Console.WriteLine("Aritmhmetic mean: " + arith);
            Console.ReadLine();

            Console.Clear();
            Console.Write("Ex2. Loading ID-Codes..."); //Ex2.
            Thread.Sleep(1200);
            Console.WriteLine("");
            string path1 = @"IdCode1.txt";
            string path2 = @"IdCode2.txt";
            string pathWrite = @"IdCodeWrite.txt";
            IdCoder(path1, path2, pathWrite);
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Ex1\nInsert some amount of money!"); //Ex1.
            double a = OnlyInt(Console.ReadLine());
            Console.WriteLine("Insert percent!");
            double b = OnlyInt(Console.ReadLine());
            Console.WriteLine("Insert numbers of years!");
            double c = OnlyInt(Console.ReadLine());
            IntrestRate(a, b, c);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("THE END!\nGoodBye!");
            Thread.Sleep(2200);
        }

        static void IntrestRate(double sum, double pro, double time) //Ex1.
        {
            for (int i = 1; i <= time;i++)
            {
                sum = sum+sum*pro/100; 
                Console.WriteLine("After {0} year(s): {1}", i, sum);
            }
        }
        static void IdCoder(string path1, string path2, string pathWrite) //Ex2.
        {
            List<string> Id1= new List<string>();
            using (StreamReader reader = new StreamReader(path1))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    Id1.Add(line);
                }
            }
            List<string> Id2 = new List<string>();
            using (StreamReader reader = new StreamReader(path2))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Id2.Add(line);
                }
            }
            using (StreamWriter writer = new StreamWriter(pathWrite, false)){} //Kustutab faili sisu enne kirjutamist.
            for (int i =0; i < Id1.Count;i++)
            {
                string add = Id2[0];
                string IDCode = Id1[i] + add;
                for (int e = 1; Id1[i].Length + add.Length != 11 && e < Id1.Count; e++)
                {
                    add = Id2[e];
                    IDCode =Id1[i] + add;
                }
                if (IDCode.Length == 11)
                {
                    Console.Write("{0}.Correct ID-Code: ",(i + 1));
                    Thread.Sleep(150);            //
                    foreach (char e in IDCode)   //
                    {                           // Educational use only!
                        Console.Write(e);      // Abiks "https://www.dotnetperls.com/sleep"
                        Thread.Sleep(30);     //  
                    }                        //
                    Console.WriteLine("");
                    using (StreamWriter writer = new StreamWriter(pathWrite, true))
                    {
                        writer.WriteLine("{1}.Correct ID-Code: {0}",IDCode, (i + 1));
                    }
                }
            }
            Console.WriteLine("Loading complete!");
        }

        static int Median(int Math) //Ex3.
        {
            List<int> numbs = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < Math; i++)
            {
                numbs.Add(rnd.Next(50));
            }
            numbs.Sort();
            foreach (int i in numbs)
            {
                Console.WriteLine(i);
            }
            if (Math % 2 == 0)
            {
                Math = (numbs[Math/2-1] + numbs[Math / 2]) / 2;
            }
            else
            {
                Math = numbs[(Math-1)/2];  
            }
            return Math; //Kasutan eelnevalt tehtud int  math-i. Vähendab koodiridu ja kasutab vähem mälu.
        }

        static int Arith(int math) //Ex3.
        {
            List<int> numbs = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < math; i++)
            {
                numbs.Add(rnd.Next(50));
            }
            numbs.Sort();
            math = 0;
            foreach (int e in numbs)
            {
                Console.WriteLine(e);
                math += e;
            }
            math = math / numbs.Count;  //Kasutan eelnevalt tehtud int  math-i. Vähendab koodiridu ja kasutab vähem mälu.
            return math; 
        }

        static void MoneyTeller(int input) //Ex4.
        {
            TV color = new TV();
            if (input.ToString().Length == 2)
            {
                int sent = Int16.Parse(input.ToString().Substring(0,2));
                color.Yellow(Sent(sent.ToString()));
            }
            else if (input.ToString().Length == 1 && input != 0)
            {
                int sent = Int16.Parse(input.ToString().Substring(0, 1));
                color.Yellow(Sent(sent.ToString()));
            }
            else if (input != 0)
            {
                int euro = Int16.Parse(input.ToString().Substring(0, 1));
                int sent = Int16.Parse(input.ToString().Substring(1, 2));
                if (sent != 0)
                {
                    color.Yellow(Euro(euro.ToString()) + " ja " + Sent(sent.ToString()));
                }
                else
                {
                    color.Yellow(Euro(euro.ToString()));
                }
            }
        }
        static string Sent(string sent)
        {
            if (sent != "1" )
            {
                sent = sent + " senti";
            }
            else
            {
                sent = "1 sent";
            }
            return sent;
        }
        static string Euro(string euro)
        {
            if (euro != "1")
            {
                euro = euro + " eurot";
            }
            else
            {
                euro = "1 euro";
            }
            return euro;
        }

        static int OnlyInt(string stringNumber) //Tegin endale string to int printeri. Ei leidnud süsteemi poolt loodud meetodit selleks.
        {
            int num = 0;
            bool run = true;
            while (run == true)
            {
                if (stringNumber.All(char.IsDigit) == true && stringNumber != "" && stringNumber.Length < 9)
                {
                    num = Int32.Parse(stringNumber);
                    run = false;
                }
                else if (stringNumber == "")
                {
                    ErrorRed("Thanks for Nothing!"); 
                    stringNumber = Console.ReadLine();
                }
                else if (stringNumber.Length >= 9)
                {
                    ErrorRed("Too long input!");
                    stringNumber = Console.ReadLine();
                }
                else
                {
                    ErrorRed("Input includes non-numberic characters!");
                    stringNumber = Console.ReadLine();
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
    }
}
