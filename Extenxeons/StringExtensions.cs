namespace Extenxeons
{
    using System.Linq;

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
                    return str.Substring(startIndex, endIndex - startIndex).ToCharArray().Reverse().ToArray()
                        .ArrayToString(string.Empty);

                default:
                    return string.Empty;
            }
        }
    }
}