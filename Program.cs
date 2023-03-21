using System;

namespace Арифметика
{
    class Program
    {
        static void Main(string[] args)
        {
            //Арифметика
            int i = 100;
            int b = 5;
            double p = 5.5;
            Console.WriteLine(p+b);
            Console.WriteLine(i-b);
            Console.WriteLine(i+b);
            Console.WriteLine(i/b);
            Console.WriteLine(i*b);
            Console.WriteLine(i%b);
            Console.WriteLine(i);
            //Объединение строк методом Join
            String a1 = "I ";
            String a2 = "love ";
            String a3 = "C# ";
            String a4 = String.Join(a2,a1,a3);
            Console.WriteLine(a4);
            //Indexof
            string b1 = "Hello world";
            char ch = 'r';
            int indexofchar = b1.IndexOf(ch);
            Console.WriteLine(indexofchar);
            //Split
            string text = "кажется есть вариант получше";
 
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
 
            foreach (string s in words)
            {
                Console.WriteLine(s);
            }
            //Replace
            string tex = "Я люблю C#";
 
            tex = tex.Replace("C#","Java");
            Console.WriteLine(tex);
            //Insert
            String Ins = "Крутая погода";
            String Ins2 = " cолнечная";
            Ins = Ins.Insert(6, Ins2);
            Console.WriteLine(Ins);
        }   
    }
}