using System.Text;

namespace DSS.ExtensionMethods
{
    public static class Extension
    {
        public static int NumberOfLetters(this string s)
        {
            int ret = 0;
            foreach (char ch in s)
            {
                if (ch >= 'a' && ch <= 'z')
                    ret++;
                if (ch >= 'A' && ch <= 'Z')
                    ret++;
            }
            return ret;
        }

        public static string Concatenate(this string s, int repeats)
        {
            if (repeats <= 1)
                return s;
            StringBuilder builder = new StringBuilder(s);
            for (int i = 1; i <= repeats; i++)
            {
                builder.Append(s);
            }
            return builder.ToString();
        }
    }
}
