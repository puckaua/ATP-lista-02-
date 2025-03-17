using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 idades diferentes:");
            int idade1 = int.Parse(Console.ReadLine());
            int idade2 = int.Parse(Console.ReadLine());
            int idade3 = int.Parse(Console.ReadLine());

            if (idade1 != idade2 && idade1 != idade3 && idade2 != idade3)
            {


                if (idade1 >= idade2 && idade1 >= idade3)
                {
                    Console.WriteLine("A maior idade informada é: " + idade1);
                }
                else if (idade1 <= idade2 && idade1 <= idade3)
                {
                    Console.WriteLine("A menor idade informada é: " + idade1);
                }
                else
                {
                    Console.WriteLine("");
                }


                if (idade2 >= idade1 && idade2 >= idade3)
                {
                    Console.WriteLine("A maior idade informada é: " + idade2);
                }
                else if (idade2 <= idade1 && idade2 <= idade3)
                {
                    Console.WriteLine("A menor idade informada é: " + idade2);
                }
                else
                {
                    Console.WriteLine("");
                }

                if (idade3 >= idade1 && idade3 >= idade2)
                {
                    Console.WriteLine("A maior idade informada é: " + idade3);
                }
                else if (idade3 <= idade1 && idade3 <= idade2)
                {
                    Console.WriteLine("A menor idade informada é: " + idade3);
                }
                else
                {
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("Digite 3 idades DIFERENTES");
            }



            Console.ReadLine();
        }
    }
}
