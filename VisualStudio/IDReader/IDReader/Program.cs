using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IDReader
{
    class Program
    {
        static void Main(string[] args)
        {
            IDReader NewIDCode = new IDReader();

            NewIDCode.CreateNewIdCode(new DateTime(1986, 7, 9), "Tartu", "Naine", 3); //ID-kood saadetakse automaatselt Decoderisse.  ID-koodi tekitaja vastavalt andmetele.
            NewIDCode.InfoPrint(); //Kuvataskse andmed consoolis
            NewIDCode.SaveIDInfo(); //Salvestatakse andmed faili
            
            IDReader decodingCode = new IDReader("39801015216"); //ID-kood saadetakse automaatselt Decoderisse.
            decodingCode.InfoPrint(); //Kuvataskse andmed consoolis
            decodingCode.SaveIDInfo(); //Salvestatakse andmed faili
            
            List<string> idCodesList = new List<string>();
            using (StreamReader reader = new StreamReader(decodingCode._destinationFileRead)) //Loetava faili asukoht asub teises classis
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    idCodesList.Add(line);
                }
            }
            foreach (string a in idCodesList) //Loeb listis olevad ID-koodid
            {
                IDReader idCode = new IDReader(a);     //ID-kood saadetakse automaatselt Decoderisse
                idCode.InfoPrint();
                idCode.SaveIDInfo();
            }
            Console.ReadLine();
        }
    }
}
