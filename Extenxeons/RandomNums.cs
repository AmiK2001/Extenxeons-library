namespace Extenxeons
{
    using System;

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
            {
                // synchronize
                return random.Next(min, max);
            }
        }
    }
}