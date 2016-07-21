using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_XML
{
    class Program
    {

        static void Main(string[] args)
        {
            FileHelper fh = new FileHelper();
            Console.WriteLine(fh.ReadFromFile(@"./input.txt"));




            /*
            List<Client> list = new List<Client> ();
            list.Add(new Client { Name = "Denny", Bank = "Sber" });
            list.Add(new Client { Name = "Ivan", Bank = "Alfa" });

            var carMake = from Client cl in list
                          where cl.Bank == "Alfa"
                          select cl.Name;

                /*list
                .Where(item => item.Bank == "Alfa")
                .Select(item => item.Name);
                
            foreach (var item in carMake)
                Console.WriteLine(item);
            */
            Console.ReadKey();
        }
    }
}
