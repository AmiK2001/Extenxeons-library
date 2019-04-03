namespace Extenxeons
{
    using System;
    using System.Linq;

    /// <summary>
    /// Класс со статическими методами генерации случайных чисел.
    /// </summary>
    public static class RandomExt
    {
        private static readonly Random random = new Random();

        private static readonly object syncLock = new object();

        /// <summary>
        /// Возвращает случайный элемент в массиве
        /// </summary>
        /// <param name="array"></param>
        /// <returns> Возвращает строку </returns>
        public static string Choice(Array array)
        {
            return array.GetValue(Int(0, array.Length)).ToString();
        }

        /// <summary>
        /// Генерирует случайное число с двойной точностью после запятой в заданном диапазоне.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="point"></param>
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
        /// Генерирует случайное целое число в заданном диапазоне.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
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