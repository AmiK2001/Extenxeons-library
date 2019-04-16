namespace Extenxeons
{
    using System;
    using System.Collections;
    using System.Text;

    /// <summary>
    /// Класс содержащий методы для преобразования других обьектов в строку.
    /// </summary>
    public static class ObjectToString
    {
        /// <summary>
        /// Разделяет элементы массива разделителем и возвращает строку.
        /// </summary>
        /// <param name="array"> Исходный массив </param>
        /// <param name="splitter"> Разделитель между элементами массива </param>
        /// <returns> Возвращает строку </returns>
        public static string ArrayToString(this Array array, string splitter = ", ")
        {
            StringBuilder stringBuilder = new StringBuilder();

            int index = 0;
            foreach (var i in array)
            {
                if (index + 1 == array.Length)
                {
                    stringBuilder.Append($"{i.ToString()}");
                }
                else
                {
                    stringBuilder.Append($"{i.ToString()}{splitter}");
                }

                index++;
            }

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Разделяет элементы списка разделителем и возвращает строку.
        /// </summary>
        /// <param name="list"> Исходный спиисок </param>
        /// <param name="splitter"> Разделитель между элементами списка </param>
        /// <returns> Возвращает строку </returns>
        public static string ListToString(this IList list, string splitter = ", ")
        {
            StringBuilder result = new StringBuilder(string.Empty);

            if (list.Count > 0)
            {
                result.Append(list[0].ToString());
                for (int i = 1; i < list.Count; i++)
                    result.AppendFormat($"{splitter}{list[i].ToString()}");
            }

            return result.ToString();
        }
    }
}