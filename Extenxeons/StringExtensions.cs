using System.Linq;

namespace Extenxeons
{
    /// <summary>
    /// Extension class of strings
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Cut string
        /// </summary>
        /// <param name="str"> String to cut </param>
        /// <param name="startIndex"> Start cut index </param>
        /// <param name="endIndex"> End cut index </param>
        /// <param name="step"> Cut step </param>
        /// <returns> Return cutted string </returns>
        public static string Slice(this string str, int startIndex, int endIndex, int step = 1)
        {
            string temp = str.Select(i => i)
                .TakeWhile(x => str.IndexOf(x) <= endIndex).Skip(startIndex)
                .ToArray().ArrayToString(string.Empty);
            
            if (step == 0 || step == 1) {
                return temp;
            }
            else if (step > 1)
            {
                return string.Join<char>(string.Empty, temp.Where((ch, index) => (index % step != 0)));
            }
            else
            {
                return string.Empty;
            }
        }
    }
}