using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Extenxeons
{
    public static class StringExtensions
    {
        public static string Slice(this string str, int startIndex, int endIndex, int step = 1)
        {
            // TODO: Сделать поддержку любого шага
            switch (step)
            {
                case 1:
                    return str.Substring(startIndex, endIndex - startIndex);
                case -1:
                    return str.Substring(startIndex, endIndex - startIndex).ToCharArray().Reverse().ToArray().ArrayToString("");
                default:
                    return "";
            }
        }
    }
    public static class StaticConsole
    {
        public static void Print(object obj)
        {
            Console.Write(obj.ToString());
        }

        public static void PrintLn(object obj)
        {
            Console.WriteLine(obj.ToString());
        }

        public static string ReadLn()
        {
            return Console.ReadLine();
        }
    }

    public static class ObjectToString
    {
        public static string ArrayToString(this Array array, string splitter = ", ")
        {
            StringBuilder stringBuilder = new StringBuilder();

            int index = 0;
            foreach (var i in array)
            {
                if (index + 1 == array.Length)
                {
                    stringBuilder.Append($"{i.ToString()}");
                }
                else
                {
                    stringBuilder.Append($"{i.ToString()}{splitter}");
                }
                index++;
            }
            return stringBuilder.ToString();
        }

        public static string ListToString(this IList list, string splitter = ", ")
        {
            StringBuilder result = new StringBuilder("");

            if (list.Count > 0)
            {
                result.Append(list[0].ToString());
                for (int i = 1; i < list.Count; i++)
                    result.AppendFormat($"{splitter}{list[i].ToString()}");
            }
            return result.ToString();
        }
    }

    public static class Randomy
    {
        public static int Int(int min, int max)
        {
            return new Random(new Random(DateTime.Now.Millisecond).Next(1, int.MaxValue)).Next(min, max);
        }

        public static double Double()
        {
            return new Random(new Random(DateTime.Now.Millisecond).Next(1, int.MaxValue)).NextDouble();
        }
    }
}