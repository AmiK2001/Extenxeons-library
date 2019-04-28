using System;

namespace Extenxeons
{
    /// <summary>
    ///     Статичный класс для облегчения работы с консольный вводом-выводом.
    /// </summary>
    public static class StaticConsole
    {
        /// <summary>
        ///     Выводит текст и читает значение в строку со стандатного входного потока.
        /// </summary>
        /// <param name="text"> Текст для вывода </param>
        /// <returns> Возвращает строку </returns>
        public static string Input(string text = "")
        {
            Print(text);
            return ReadLn();
        }

        /// <summary>
        ///     Записывает заданное строковое значение объекта в стандартный выходной поток.
        /// </summary>
        /// <param name="obj"> Объект для вывода строкового значения </param>
        public static void Print(object obj)
        {
            Console.Write(obj.ToString());
        }

        /// <summary>
        ///     Записывает заданное строковое значение объекта, за которым следует признак конца строки,
        ///     в стандартный выходной поток.
        /// </summary>
        /// <param name="obj"> Объект для вывода строкового значения </param>
        public static void PrintLn(object obj = null)
        {
            if (obj == null)
                Console.WriteLine();
            else
                Console.WriteLine(obj.ToString());
        }

        /// <summary>
        ///     Считывает следующую строку из стандартного входного потока.
        /// </summary>
        /// <returns> Возвращает считанную строку </returns>
        public static string ReadLn()
        {
            return Console.ReadLine();
        }

        /// <summary>
        ///     Выводит текст и ожидает нажатия любой клавиши.
        /// </summary>
        /// <param name="text"> Отображаемый текст </param>
        /// <param name="nextLineBefore"> Перемещать на следующую строку перед выводом текста </param>
        public static void WaitKey(string text = "Нажмите любую клавишу для выхода...", bool nextLineBefore = true)
        {
            if (nextLineBefore) PrintLn(string.Empty);

            Print(text);
            Console.ReadKey();
        }
    }
}