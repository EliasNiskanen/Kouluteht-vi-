﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Käyttöliittymä_projekti_1
{

    class Program
    {
        static void Main(string[] args)
        {

            Keskikulutus keskik;
            keskik.Matka = 0;
            keskik.Aine = 0;
            keskik.Keskikulutus = 100 * keskik.Aine / keskik.Matka;
            

            Console.WriteLine("Kuinka pitkä oli matka? ");
            keskik.Matka = double.Parse(Console.ReadLine());

            Console.WriteLine("Kuinka paljon meni polttoainetta? ");
            keskik.Aine = double.Parse(Console.ReadLine());

            Console.WriteLine("Keskikulutuksesi on : ", keskik.Keskikulutus);


        }
    }
}

