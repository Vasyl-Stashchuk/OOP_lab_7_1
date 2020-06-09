using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.GetEncoding(1251);

            Computers computers = new Computers();
            computers.Add(new Computer("Lenovo", "G510", "black", 1245, 256));
            computers.Add(new Computer("Lenovo", "G550", "silver", 5689, 512));
            computers.Add(new Computer("Aser", "E 10", "black", 10589, 512));
            computers.Add(new Computer("Aser", "E 15", "black", 20589, 512));
            computers.Add(new Computer("Asus", "M234", "white", 14895, 512));
            computers.Add(new Computer("HP", "A235", "white", 10258, 256));
            computers.Add(new Computer("Lenovo", "G600", "black", 5896, 256));
            computers.Add(new Computer("Asus", "M125", "red", 11458, 512));
            computers.Add(new Computer("Samsung", "A100", "black", 16789, 256));
            computers.Add(new Computer("Samsung", "A200", "white", 20500, 512));

            ArrayList arrayList = new ArrayList();
            foreach (Computer c in computers)
                arrayList.Add(c);

            Console.WriteLine("Сортування за ціною(ICompareble):");
            arrayList.Sort();
            foreach (Computer a in arrayList)
                a.showInfo();

            Console.WriteLine("Сортування за ціною(IComparer):");
            arrayList.Sort(new Computer.SortByPrice());
            foreach (Computer a in arrayList)
                a.showInfo();

            Console.WriteLine("Сортування за розміром жосткого діска:");
            arrayList.Sort(new Computer.SortBySpace());
            foreach (Computer a in arrayList)
                a.showInfo();

            Console.ReadLine();

        }
    }
}
