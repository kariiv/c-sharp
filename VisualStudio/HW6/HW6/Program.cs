using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HW6
{
    interface IIrons
    {
        void Descale();
        void DoIroning(int temp);
        void DoIroning(string program);
        void UseSteam();
        void TurnOn();
        void TurnOff();

    }
    class Regular : IIrons
    {
        internal int _temp;
        internal bool _status;
        internal int _descaleCount;
        internal bool _steam;
        internal string _program;
        internal string _iron;

        public Regular()
        {
            _status = false;
            _temp = 0;
            _descaleCount = 0;
            _steam = false;
            _iron = "Iron";
        }

        public void Descale() //Motion Effect added
        {
            _descaleCount = 0;
            string loading = "...";
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Cleaning");
                foreach (char e in loading)
                {
                    Thread.Sleep(250);
                    Console.Write(e);
                }
                Thread.Sleep(250);
                Console.Clear();
            }
            Console.WriteLine("Iron is cleaned!");
        }
        public virtual void ProgramPrint(string iron)
        {
            if (_program == "syn")
            {
                Console.WriteLine(iron + " machine is ironing with {0} degrees", _temp);
            }
            else if (_program == "silk")
            {
                Console.WriteLine(iron + " machine is ironing with {0} degrees", _temp);
            }
            else if (_program == "cot")
            {
                Console.WriteLine(iron + " machine is ironing with {0} degrees", _temp);
            }
        }

        public virtual void DoIroning(int temp)
        {
            _temp = temp;
            if (_descaleCount < 3 && temp < 201)
            {
                if (temp < 120 && temp > 89)
                {
                    Console.WriteLine("Synthetics program selected!");
                    _program = "syn";
                    ProgramPrint(_iron);
                }
                else if (temp < 150)
                {
                    Console.WriteLine("Silk program selected!");
                    _program = "silk";
                    ProgramPrint(_iron);
                }
                else if (temp < 200)
                {
                    Console.WriteLine("Cotton program selected!");
                    _program = "cot";
                    ProgramPrint(_iron);
                }
                UseSteam();
                _descaleCount += 1;
                Thread.Sleep(2000);
                Console.WriteLine("Ready!");
                Thread.Sleep(1500);
                Console.Clear();
            }
            else if (_descaleCount != 3)
            {
                ErrorRed("Invalid temperature range for ironing!");
            }
            Cleaner();
        }
        public virtual void Cleaner()
        {
            if (_descaleCount == 3)
            {
                WarningYellow("Machine has been used 3 times and needs cleaning");
                Thread.Sleep(3000);
                Console.Clear();
            }
        }
        public void ErrorRed(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public void WarningYellow(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public virtual void DoIroning(string program)
        {
            Random rnd = new Random();
            if (_descaleCount < 3 && (program == "Linen" || program == "linen" || program == "Synthetics" || program == "synthetics" || program == "Silk" || program == "silk" || program == "Cotton" || program == "cotton"))
            {
                if ((program == "Synthetics" || program == "synthetics"))
                {
                    Console.WriteLine("Synthetics program selected!");
                    _temp = rnd.Next(91, 120);
                    _program = "syn";
                    ProgramPrint(_iron);
                }
                else if (program == "Silk" || program == "silk")
                {
                    Console.WriteLine("Silk program selected!");
                    _temp = rnd.Next(121, 150);
                    _program = "silk";
                    ProgramPrint(_iron);
                }
                else if (program == "Cotton" || program == "cotton")
                {
                    Console.WriteLine("Cotton program selected!");
                    _temp = rnd.Next(121, 150);
                    _program = "cot";
                    ProgramPrint(_iron);
                }
                UseSteam();
                _descaleCount += 1;
                Thread.Sleep(2000);
                Console.WriteLine("Ready!");
                Thread.Sleep(1500);
                Console.Clear();
            }
            else if (_descaleCount != 3)
            {
                ErrorRed("We do not have a program for ironing " + program);
                Console.Clear();
            }
            Cleaner();
        }
        public virtual void UseSteam()
        {
            if (_temp > 119 && _steam)
            {
                Console.WriteLine("Ironing with steam!");
            }
            else if (_steam)
            {
                WarningYellow("Steam can be used with temp 120 and higher!");
            }
        }
        public void TurnOn()
        {
            _status = true;
            Console.WriteLine("Iron is turned on!");
        }
        public void TurnOff()
        {
            _status = false;
            Console.WriteLine("Iron is turned off");
        }
        public void Status()
        {
            if (_status)
            {
                Console.WriteLine("Iron is ON");
            }
            else
            {
                Console.WriteLine("Iron is OFF");
            }
        }

    }
    class Premium : Regular 
    {
        internal int _steamCount;
        public Premium()
        {
            _steamCount = 0;
        }
        public override void Cleaner()
        {
            if (_descaleCount == 3)
            {
                WarningYellow("Machine has been used 3 times cleaning automatically!");
                Thread.Sleep(2000);
                Descale();
            }
        }
        public override void UseSteam()
        {
            if (_steamCount < 2)
            {
                base.UseSteam();
                _steamCount += 1;
            }
            if (_steamCount == 2)
            {
                WarningYellow("Warning! Add water to the machine!");
                _steamCount = 0;
            }

        }
    }
    class Linen : Regular
    {
        
        public Linen()
        {
            _iron = "Linen";
        }

        public override void DoIroning(string program)
        {
            Random rnd = new Random();
            if (_descaleCount < 3 && (program == "Linen" || program == "linen"))
            {
                Console.WriteLine("Synthetics program selected!");
                _temp = rnd.Next(201, 230);
                _program = "lin";
                ProgramPrint(_iron);
            }
            base.DoIroning(program);
        }
        public override void DoIroning(int temp)
        {
            _temp = temp;
            if (temp < 231 && temp > 199)
            {
                Console.WriteLine("Linen program selected!");
                _program = "lin";
                ProgramPrint(_iron);
            }
            base.DoIroning(temp);
        }
        public override void ProgramPrint(string iron)
        {
            if (_program == "lin")
            {
                Console.WriteLine(iron + " machine is ironing with {0} degrees", _temp);
            }
            base.ProgramPrint(iron);
        }
        public override void UseSteam()
        {
            if (_temp > 119)
            {
                Console.WriteLine("Ironing with steam!");
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Regular Regular = new Regular();
            Premium Premium = new Premium();
            Linen Linen = new Linen();
            string iron = null;
            bool choose = true;
            bool run = true;
            while (run)
            {
                while (choose)
                {
                    Console.WriteLine("Choose iron U want to use!\n1) Regular\n2) Premium\n3) Linen");
                    iron = Console.ReadLine();
                    Console.Clear();
                    if (iron == "Regular" || iron == "regular" || iron == "1")
                    {
                        iron = "Regular";
                        choose = false;
                    }
                    else if (iron == "Premium" || iron == "premium" || iron == "2")
                    {
                        iron = "Premium";
                        choose = false;
                    }
                    else if (iron == "Linen" || iron == "linen" || iron == "3")
                    {
                        iron = "Linen";
                        choose = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                while (choose == false)
                {
                    Console.WriteLine(iron + " iron selected!");
                    if (iron == "Regular")
                    {
                        Console.WriteLine("Status:");
                        Regular.Status();
                        Console.WriteLine("Selections:\n1) Turn on/off\n2) Do ironing\n3) Use steam ({0})\n4) Clean\n5) Change iron \n6) Exit", Regular._steam);
                        string inP = Console.ReadLine();
                        Console.Clear();
                        if (inP == "1")
                        {
                            if (Regular._status)
                            {
                                Regular.TurnOff();
                            }
                            else
                            {
                                Regular.TurnOn();
                            }
                        }
                        else if (inP == "2" && Regular._status)
                        {
                            Console.WriteLine("Select program U want to use!\n150°C - 199 °C: Cotton program\n120°C - 149 °C: Silk program\n90°C - 119 °C: Synthetics program");
                            string program = Console.ReadLine();
                            if (program.All(Char.IsDigit) && program != "" && program.Length < 4)
                            {
                                Regular.DoIroning(Int16.Parse(program));
                            }
                            else
                            {
                                Regular.DoIroning(program);
                            }
                        }
                        else if (inP == "3" && Regular._status)
                        {
                            if (Regular._steam)
                            {
                                Regular._steam = false;
                            }
                            else
                            {
                                Regular._steam = true;
                            }
                        }
                        else if (inP == "4" && Regular._status)
                        {
                            Regular.Descale();
                        }
                        else if (inP == "5")
                        {
                            choose = true;
                        }
                        else if (inP == "6")
                        {
                            choose = true;
                            run = false;
                        }
                    }
                    else if (iron == "Premium")
                    {
                        Console.WriteLine("Status:");
                        Premium.Status();
                        Console.WriteLine("Selections:\n1) Turn on/off\n2) Do ironing\n3) Use steam ({0})\n4) Change iron \n5) Exit", Premium._steam);
                        string inP = Console.ReadLine();
                        Console.Clear();
                        if (inP == "1")
                        {
                            if (Premium._status)
                            {
                                Premium.TurnOff();
                            }
                            else
                            {
                                Premium.TurnOn();
                            }
                        }
                        else if (inP == "2" && Premium._status)
                        {
                            Console.WriteLine("Select program U want to use!\n150°C - 199 °C: Cotton program\n120°C - 149 °C: Silk program\n90°C - 119 °C: Synthetics program");
                            string program = Console.ReadLine();
                            if (program.All(Char.IsDigit) && program != "" && program.Length < 4)
                            {
                                Premium.DoIroning(Int16.Parse(program));
                            }
                            else
                            {
                                Premium.DoIroning(program);
                            }
                        }
                        else if (inP == "3" && Premium._status)
                        {
                            if (Premium._steam)
                            {
                                Premium._steam = false;
                            }
                            else
                            {
                                Premium._steam = true;
                            }
                        }
                        else if (inP == "4")
                        {
                            choose = true;
                        }
                        else if (inP == "5")
                        {
                            choose = true;
                            run = false;
                        }
                    }
                    else if (iron == "Linen")
                    {
                        Console.WriteLine("Status:");
                        Linen.Status();
                        Console.WriteLine("Selections:\n1) Turn on/off\n2) Do ironing\n3) Clean\n4) Change iron \n5) Exit");
                        string inP = Console.ReadLine();
                        Console.Clear();
                        if (inP == "1")
                        {
                            if (Linen._status)
                            {
                                Linen.TurnOff();
                            }
                            else
                            {
                                Linen.TurnOn();
                            }
                        }
                        else if (inP == "2" && Linen._status)
                        {
                            Console.WriteLine("Select program U want to use!\n200°C -230 °C : Linen program\n150°C - 199 °C: Cotton program\n120°C - 149 °C: Silk program\n90°C - 119 °C: Synthetics program");
                            string program = Console.ReadLine();
                            if (program.All(Char.IsDigit) && program != "" && program.Length < 4)
                            {
                                Linen.DoIroning(Int16.Parse(program));
                            }
                            else
                            {
                                Linen.DoIroning(program);
                            }
                        }
                        else if (inP == "3" && Linen._status)
                        {
                            Linen.Descale();
                        }
                        else if (inP == "4")
                        {
                            choose = true;
                        }
                        else if (inP == "5")
                        {
                            choose = true;
                            run = false;
                        }
                    }
                }
            }
            Console.Clear();
            Console.WriteLine("GoodBye!");
            Thread.Sleep(1000);
        }
    }
}
