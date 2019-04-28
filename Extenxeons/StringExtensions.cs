using System.Linq;

namespace Extenxeons
{
    /// <summary>
    ///     Расшиоенный класс строк.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        ///     Срезает часть строки
        /// </summary>
        /// <param name="str"> Исходная строка </param>
        /// <param name="startIndex"> Начальный индекс среза </param>
        /// <param name="endIndex"> Конечный индекс среза </param>
        /// <param name="step"> Шаг среза </param>
        /// <returns> Возвращает срезанную строку </returns>
        public static string Slice(this string str, int startIndex, int endIndex, int step = 1)
        {
            var temp = str.Select(i => i)
                .TakeWhile(x => str.IndexOf(x) <= endIndex).Skip(startIndex)
                .ToArray().ArrayToString(string.Empty);

            if (step == 0 || step == 1)
                return temp;
            if (step > 1)
                return string.Join(string.Empty, temp.Where((ch, index) => index % step != 0));
            return string.Empty;
        }

        /// <summary>
        ///     Проверяет, все ли символы в строке являются числами
        /// </summary>
        /// <param name="str"> Входная строка </param>
        /// <returns> Возвращает true, если все символы в строке числа </returns>
        public static bool IsAllDigits(this string str)
        {
            return str.All(char.IsDigit) && !string.IsNullOrEmpty(str);
        }
    }
}