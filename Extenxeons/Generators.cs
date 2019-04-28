using System.Linq;

namespace Extenxeons
{
    /// <summary>
    ///     Класс содержащий методы генерации разных структур данных.
    /// </summary>
    public static class Generators
    {
        /// <summary>
        ///     Генерирует строку с символами в диапазоне {A-Z} и {a-z} и {0-9} заданной длины.
        /// </summary>
        /// <param name="size"> Длина генерируемой строки </param>
        /// <returns> Возвращает случайную строку </returns>
        public static string GenerateString(int size)
        {
            var chars = Enumerable.Range('A', 'Z' - 'A' + 1).Select(c => (char) c)
                .Concat(Enumerable.Range('a', 'z' - 'a' + 1).Select(c => (char) c))
                .Concat(Enumerable.Range(48, 9).Select(c => (char) c)).ToArray();

            return Enumerable.Range(0, size).Select(i => chars[RandomExt.Int(0, chars.Length)]).ToArray()
                .ArrayToString(string.Empty);
        }
    }
}