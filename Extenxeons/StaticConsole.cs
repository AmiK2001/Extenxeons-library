namespace Extenxeons
{
    using System;

    /// <summary>
    /// Класс статических методов, которые облегчают работу с консолью.
    /// </summary>
    public static class StaticConsole
    {
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
        /// Выводит текст и ожидает нажатия любой клавиши.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="nextLineBefore"></param>
        public static void WaitKey(string text = "Нажмите любую клавишу для выхода...", bool nextLineBefore = true)
        {
            if (nextLineBefore == true)
            {
                PrintLn(string.Empty);
            }

            Print(text);
            Console.ReadKey();
        }
    }
}