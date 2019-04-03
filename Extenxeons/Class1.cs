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
        /// <summary>
        /// Записывает заданное строковое значение обьекта в стандартный выходной поток.
        /// </summary>
        /// <param name="obj"></param>
        public static void Print(object obj)
        {
            Console.Write(obj.ToString());
        }

        /// <summary>
        /// Записывает заданное строковое значение обьекта, за которым следует признак конца строки,
        /// в стандартный выходной поток.
        /// </summary>
        /// <param name="obj"></param>
        public static void PrintLn(object obj)
        {
            Console.WriteLine(obj.ToString());
        }

        /// <summary>
        /// Считывает следующую строку из стандартного входного потока.
        /// </summary>
        /// <returns> Возвращает считанную строку </returns>
        public static string ReadLn()
        {
            return Console.ReadLine();
        }

        /// <summary>
        /// Выводит текст и получает строковое значение из стандартного входного потока.
        /// </summary>
        /// <param name="text"></param>
        /// <returns> Возвращает считанную строку </returns>
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

    /// <summary>
    /// Класс содержащий методы для преобразования других обьектов в строку.
    /// </summary>
    public static class ObjectToString
    {
        /// <summary>
        /// Разделяет элементы массива разделителем и возвращает строку.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="splitter"></param>
        /// <returns> Возвращает строку </returns>
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
        /// <returns> Возвращает строку </returns>
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

    /// <summary>
    /// Класс со статическими методами генерации случайных чисел.
    /// </summary>
    public static class RandomNums
    {
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();

        /// <summary>
        /// Генерирует случайное целое число в заданном диапазоне.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns> Возвращает случайное целое число </returns>
        public static int Int(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return random.Next(min, max);
            }
        }
    }

    /// <summary>
    /// Класс содержащий методы генерации разных структур данных.
    /// </summary>
    public static class Generators
    {
        /// <summary>
        /// Генерирует строку с символами в диапазоне {A-Z} и {a-z} и {0-9} заданной длины.
        /// </summary>
        /// <param name="size"></param>
        /// <returns> Возвращает случайную строку </returns>
        public static string GenerateString(int size)
        {
            char[] chars = Enumerable.Range('A', 'Z' - 'A' + 1)
                .Select(c => (char)c)
                .Concat(Enumerable.Range('a', 'z' - 'a' + 1)
                .Select(c => (char)c))
                .Concat(Enumerable.Range(48, 9)
                .Select(c => (char)c))
                .ToArray();

            return Enumerable.Range(0, size)
                .Select(i => chars[RandomNums.Int(0, chars.Length)])
                .ToArray()
                .ArrayToString("");
        }
    }
}