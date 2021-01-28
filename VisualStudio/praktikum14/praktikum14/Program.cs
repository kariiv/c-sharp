using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikum14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sorting machine
            Sorter sorter = new Sorter();
            sorter.Sorting();

            //String Monipulation
            EmailEnDeCode email = new EmailEnDeCode();
            email.DecodeAccount("mina.olen@tTu.ee");
            email.DecodeAccount("raadik@ERR.ee");
            email.DecodeAccount("Urr.ee\\kalake");
            email.DecodeAccount("Urr.ee\\kalake.vees");
            email.DecodeAccount("#Rfaf|maw.ee\\kiisu.miisu.Eliis");

            email.EncodeAccount("EER.ee Merka liina Mustikas");
            email.EncodeAccount("eest.ue Kris karu  de almiro");
            email.EncodeAccount("es.eu mariaias");

            Console.ReadLine();
            //Second EX string[] array = a.split('@')
            AccountingSystem acc = new AccountingSystem();
            acc.Account();
        }
    }
}
