namespace Extenxeons {
    using System.Linq;

    /// <summary>
    /// Класс расширенных методов строк, представляющий новые методы.
    /// </summary>
    public static class StringExtensions {
        /// <summary>
        /// Срезает строку
        /// </summary>
        /// <param name="str"> Исходная строка </param>
        /// <param name="startIndex"> Начальный индекс среза </param>
        /// <param name="endIndex"> Конечный индекс среза </param>
        /// <param name="step"> Шаг среза </param>
        /// <returns> Возвращает срезанную строку </returns>
        public static string Slice(this string str, int startIndex, int endIndex, int step = 1) {
            // TODO: Сделать поддержку любого шага.
            switch (step) {
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