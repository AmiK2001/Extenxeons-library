namespace Extenxeons
{
    using System;

    /// <summary>
    /// Static methods class to simplify Console IO.
    /// </summary>
    public static class StaticConsole
    {
        /// <summary>
        /// Print text and read string value from standard input stream.
        /// </summary>
        /// <param name="text"> Text to print </param>
        /// <returns> Return string </returns>
        public static string Input(string text = "")
        {
            Print(text);
            return ReadLn();
        }

        /// <summary>
        /// Записывает заданное строковое значение объекта в стандартный выходной поток.
        /// </summary>
        /// <param name="obj"> Объект для вывода строкового значения </param>
        public static void Print(object obj)
        {
            Console.Write(obj.ToString());
        }

        /// <summary>
        /// Записывает заданное строковое значение объекта, за которым следует признак конца строки,
        /// в стандартный выходной поток.
        /// </summary>
        /// <param name="obj"> Объект для вывода строкового значения </param>
        public static void PrintLn(object obj = null)
        {
            if (obj == null)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(obj.ToString());
            }
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
        /// <param name="text"> Отображаемый текст </param>
        /// <param name="nextLineBefore"> Перемещать на следующую строку перед выводом текста </param>
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