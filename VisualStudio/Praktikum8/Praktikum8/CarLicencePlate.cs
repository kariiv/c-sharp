using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum8
{
    class CarLicencePlate
    {
        List<string> CarNumbersAll = new List<string>();
        Random rnd = new Random();

        public List<string> Generate4Code(string letters)
        {
            List<string> codes = new List<string>();
            for (int i = 0; i < 4 ;i++)
            {
                string code = GenerateCode(letters);
                codes.Add(code);
            }
            CarNumbersAll.AddRange(codes);

            return codes;
        }

        public string GenerateCode(string letter)
        {
            string generateCode = "";
            if (letter.Length == 3)
                for (int i = 0; i < 3; i++)
                    generateCode += rnd.Next(0, 9);
            generateCode += letter;
            return generateCode;
        }
    }
}
