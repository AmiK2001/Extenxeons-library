using System.Linq;

namespace Extenxeons
{
    /// <summary>
    ///     ����������� ����� �����.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        ///     ������� ����� ������
        /// </summary>
        /// <param name="str"> �������� ������ </param>
        /// <param name="startIndex"> ��������� ������ ����� </param>
        /// <param name="endIndex"> �������� ������ ����� </param>
        /// <param name="step"> ��� ����� </param>
        /// <returns> ���������� ��������� ������ </returns>
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
        ///     ���������, ��� �� ������� � ������ �������� �������
        /// </summary>
        /// <param name="str"> ������� ������ </param>
        /// <returns> ���������� true, ���� ��� ������� � ������ ����� </returns>
        public static bool IsAllDigits(this string str)
        {
            return str.All(char.IsDigit) && !string.IsNullOrEmpty(str);
        }
    }
}