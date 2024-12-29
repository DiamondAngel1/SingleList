using System;
using System.Text;

namespace SingleList{
    internal class Program{
        static void Main(string[] args){
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            SingleList<int> list = new SingleList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Print();
            Console.WriteLine("Видалення елемента 2: " + list.Remove(2));
            list.Print();
            Console.WriteLine("Елемент 3 існує в списку: " + list.Exist(4));
            Console.WriteLine("Елемент 2 існує в списку: " + list.Exist(2));
            list.Reverse();
            list.Print();
            Console.WriteLine("Елемент по индексу 1: " + list.GetIndex(1));
            Console.WriteLine("Кількість елементів: " + list.Count);
        }
    }
}
