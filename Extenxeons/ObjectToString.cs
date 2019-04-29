using System;
using System.Collections;
using System.Text;

namespace Extenxeons
{
    /// <summary>
    ///     Преобразует объект из одного типа в строку
    /// </summary>
    public static class ObjectToString
    {
        /// <summary>
        ///     Преобразует значение данного экземпляра в String
        /// </summary>
        /// <param name="array"> Экземпляр объекта </param>
        /// <param name="splitter"> Разделитель между элементами </param>
        /// <returns> Возвращает строковой вид объекта </returns>
        public static string ArrayToString(this Array array, string splitter = ", ")
        {
            var stringBuilder = new StringBuilder();

            var index = 0;
            foreach (var i in array)
            {
                stringBuilder.Append(index + 1 == array.Length ? $"{i}" : $"{i}{splitter}");
                index++;
            }

            return stringBuilder.ToString();
        }

        /// <summary>
        ///     Преобразует значение данного экземпляра в String
        /// </summary>
        /// <param name="list"> Экземпляр объекта </param>
        /// <param name="splitter"> Разделитель между элементами </param>
        /// <returns> Возвращает строковой вид объекта </returns>
        public static string ListToString(this IList list, string splitter = ", ")
        {
            var result = new StringBuilder();

            if (list.Count <= 0) return result.ToString();
            result.Append(list[0]);

            for (var i = 1; i < list.Count; i++)
                result.AppendFormat($"{splitter}{list[i]}");

            return result.ToString();
        }
    }
}