using System;
using System.Collections;
using System.Text;

namespace Extenxeons
{
    /// <summary>
    ///     ����������� ������ �� ������ ���� � ������
    /// </summary>
    public static class ObjectToString
    {
        /// <summary>
        ///     ����������� �������� ������� ���������� � String
        /// </summary>
        /// <param name="array"> ��������� ������� </param>
        /// <param name="splitter"> ����������� ����� ���������� </param>
        /// <returns> ���������� ��������� ��� ������� </returns>
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
        ///     ����������� �������� ������� ���������� � String
        /// </summary>
        /// <param name="list"> ��������� ������� </param>
        /// <param name="splitter"> ����������� ����� ���������� </param>
        /// <returns> ���������� ��������� ��� ������� </returns>
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