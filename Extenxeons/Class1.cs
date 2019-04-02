using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Extenxeons
{
    /// <summary>
    /// Класс расширенных методов строк, предостовляющий новые методы.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Производит срез строки.
        /// </summary>
        public static string Slice(this string str, int startIndex, int endIndex, int step = 1)
        {
            // TODO: Сделать поддержку любого шага.
            switch (step)
            {
                case 1:
                    return str.Substring(startIndex, endIndex - startIndex);

                case -1:
                    return str.Substring(startIndex, endIndex - startIndex)
                        .ToCharArray()
                        .Reverse()
                        .ToArray()
                        .ArrayToString("");

                default:
                    return "";
            }
        }
    }

    /// <summary>
    /// Класс статических методов, которые облегчают работу с консолью.
    /// </summary>
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

        /// <summary>
        /// Выводит текст и получает строковое значение с консольного потока ввода.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string Input(string text = "")
        {
            Print(text);
            return ReadLn();
        }

        /// <summary>
        /// Выводит текст и ожидает нажатия любой клавиши.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="nextLineBefore"></param>
        public static void WaitKey(string text = "Нажмите любую клавишу для выхода...", bool nextLineBefore = true)
        {
            if (nextLineBefore == true)
            {
                PrintLn("");
            }

            Print(text);
            Console.ReadKey();
        }
    }

    public static class ObjectToString
    {
        /// <summary>
        /// Разделяет элементы массива разделителем и возвращает строку.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="splitter"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Разделяет элементы списка разделителем и возвращает строку.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="splitter"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Генерирует случайное целое число в заданном диапазоне.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int Int(int min, int max)
        {
            return new Random(DateTime.Now.Millisecond).Next(min, max);
        }
    }
}