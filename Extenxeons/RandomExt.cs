using System;
using System.Linq;

namespace Extenxeons
{
    /// <summary>
    ///     Класс со статическими методами генерации случайных чисел.
    /// </summary>
    public static class RandomExt
    {
        private static readonly Random random = new Random();

        private static readonly object syncLock = new object();

        /// <summary>
        ///     Возвращает случайный элемент в массиве.
        /// </summary>
        /// <param name="array"> Массив элементов, из которых производится выбор </param>
        /// <returns> Возвращает строку </returns>
        public static string Choice(Array array)
        {
            return array.GetValue(Int(0, array.Length)).ToString();
        }

        /// <summary>
        ///     Генерирует случайное число с двойной точностью после запятой в заданном диапазоне.
        /// </summary>
        /// <param name="min"> Минимальное значение диапазона генерации </param>
        /// <param name="max"> Минимальное значение диапазона генерации </param>
        /// <param name="point"> Количество цифр после запятой </param>
        /// <returns> Возвращает случайное число с двойной точностью после запятой </returns>
        public static double Double(int min, int max, int point = 2)
        {
            lock (syncLock)
            {
                return double.Parse(
                    $"{random.Next(min, max)}," + string.Concat<string>(
                        Enumerable.Range(0, point).Select(i => random.Next(0, 9).ToString())));
            }
        }

        /// <summary>
        ///     Генерирует случайное целое число в заданном диапазоне.
        /// </summary>
        /// <param name="min"> Минимальное значение диапазона генерации </param>
        /// <param name="max"> Минимальное значение диапазона генерации </param>
        /// <returns> Возвращает случайное целое число </returns>
        public static int Int(int min, int max)
        {
            lock (syncLock)
            {
                return random.Next(min, max);
            }
        }
    }
}