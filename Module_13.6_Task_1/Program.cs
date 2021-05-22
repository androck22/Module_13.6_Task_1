using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Module_13._6_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Lenovo\source\repos\Module_13.6_Task_1\cdev_Text.txt";

            var textList1 = new List<string>();
            var textList2 = new LinkedList<string>();

            var stopWatch1 = Stopwatch.StartNew();
            try
            {
                using (var sr = new StreamReader(path))
                {
                    var text = sr.ReadToEnd();
                    foreach (var item in text.Split(' ', '!', '\''))
                    {
                        textList1.Add(item);
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine($"Производительность вставки в List<T>: {stopWatch1.Elapsed.TotalMilliseconds}");

            Console.WriteLine();

            var stopWatch2 = Stopwatch.StartNew();
            try
            {
                using (var sr = new StreamReader(path))
                {
                    var text = sr.ReadToEnd();

                    foreach (var item in text.Split(' ', '!', '\''))
                    {
                        textList2.AddFirst(item);
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine($"Производительность вставки в LinkedList<T>: {stopWatch2.Elapsed.TotalMilliseconds}");

            Console.ReadLine();
        }
    }
}
