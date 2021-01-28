using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    class Exercises
    {
        //Ex1
        public string AddsTwoStrings(string a, string b)
        {
            return a + b;
        }

        //EX2
        public Array ArrayOfNumbers()
        {
            int[] arry = new int[6];
            Random rnd = new Random();
            
            arry[0] = (rnd.Next(1, 10) * 2) - 1;
            arry[1] = rnd.Next(1, 20);
            arry[2] = rnd.Next(15, 30) * 2;
            arry[3] = (rnd.Next(16, 31) * 2) - 1;
            arry[4] = rnd.Next(50, 100) * 2;
            arry[5] = rnd.Next(25, 40) * 5;
            
            return arry;
        }

        //Ex3
        public string BMI(double weight, double height)
        {
            string weightStatus;
            if (weight != 0 && height != 0)
            {//BMI calculation
                weight = weight / (height * height);
                if (weight < 18.5)
                    return weightStatus = "Underweight";
                else if (weight < 25)
                    return weightStatus = "Normal";
                else if (weight < 30)
                    return weightStatus = "Overweight";
                else
                    return weightStatus = "Obese";
            }
            return weightStatus = "Invalid";
        }

        //Ex4
        public string ReplaceSpaces(string sentence)
        {
            string noSpaces = null;
            bool lastWasSpace = false;
            foreach(char e in sentence)
            {
                if (e != ' ')
                {
                    noSpaces += e;
                    lastWasSpace = false;
                }
                else if (e == ' ' && !lastWasSpace) //skips other spaces
                {
                    noSpaces += '*';
                    lastWasSpace = true;
                }
            }
            return noSpaces;
        }

    }
}
