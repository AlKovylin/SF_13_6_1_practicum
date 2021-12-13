using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace SF_13_6_1_practicum
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Text1.txt";

            //Запускать выполнение функций измерения по одной
            TestTimeList(path);
            //TestTimeLinkedList(path);
        }

        private static void TestTimeList(string path)
        {
            List<string> TestList = new List<string>();
            Stopwatch timer;

            timer = Stopwatch.StartNew();

            string[] lines = File.ReadAllLines(path);

            foreach (var line in lines)
            {
                TestList.Add(line);
            }

            timer.Stop();

            Console.WriteLine($"Время вставки текста в List<>: {timer.ElapsedMilliseconds} мс");
            Console.WriteLine($"List содержит: {TestList.Count} строк.");
        }

        private static void TestTimeLinkedList(string path)
        {
            LinkedList<string> TestLinkedList = new LinkedList<string>();
            Stopwatch timer;

            timer = Stopwatch.StartNew();

            string[] lines1 = File.ReadAllLines(path);

            foreach (var line in lines1)
            {
                TestLinkedList.AddFirst(line);
            }

            timer.Stop();

            Console.WriteLine($"Время вставки текста в LinkedList<>: {timer.ElapsedMilliseconds} мс");
            Console.WriteLine($"LinkedList содержит: {TestLinkedList.Count} строк.");
        }
    }
}