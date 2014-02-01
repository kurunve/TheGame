
using System.Text;

namespace Game.Levels
{
    class Level1
    {
        public static string HelloWorld()
        {//ho ho ho
            return "Hello, World!";
        }

        /// <summary>
        /// function
        /// </summary>
        /// <param name="user_name"></param>
        /// <returns></returns>
        public static string Hello(string user_name)
        {
            bool flag = false;
            string[] mass = user_name.Split(' ');
            string name = "";
            if (char.GetUnicodeCategory(mass[0][0]) == System.Globalization.UnicodeCategory.UppercaseLetter)
            {
                name = user_name;
            }
            else
            {
                for (int i = 0; i < mass.Length; ++i)
                {
                    if (char.GetUnicodeCategory(mass[i][0]) == System.Globalization.UnicodeCategory.LowercaseLetter)
                    {
                        string temp = "";
                        temp += mass[i][0];
                        temp = temp.ToUpper();
                        for (int j = 1; j < mass[i].Length; ++j)
                            temp += mass[i][j];

                        name += temp + " ";
                        flag = true;
                    }

                    else
                    {
                        name += mass[i];
                    }
                }
            }
            if (flag == false)
                return string.Format("{0}, {1}!", "Hello", name.TrimEnd(' '));
            else
            {
                return string.Format("{0}, {1}.", "Hello", name.TrimEnd(' '));
            }
        }

        public static string FizzBuzzTest(int i)
        {
            if (i % 3 == 0)
                return "Fizz";
            else
                if (i % 5 == 0)
                    return "Buzz";
                else
                    return i.ToString();
        }

        private static string makeString(string str, int length)
        {
            if (str.Length >= length)
                return str;
            int num = length - str.Length;
            for (int i = 0; i < num; ++i)
                str += str[i];
            return str;
        }

        public static string StringReverse(string a, string b)
        {
            int maxLength = a.Length > b.Length ? a.Length : b.Length;
            a = makeString(a,maxLength);
            b = makeString(b,maxLength);
            string second = "";
            for (int i = 0; i < b.Length; ++i)
            {
                if (char.IsLower(b[i]))
                    second += b[i].ToString().ToUpper();
                else
                    if (char.IsUpper(b[i]))
                        second += b[i].ToString().ToLower();
            }
            string rez = "";
            for (int i = 0; i < maxLength; ++i)
            {
                rez += a[i];
                rez += second[i];
            }
            return rez;
        }

        private static int findSumOfAllDigids(string str)
        {
            int rez = 0;
            for (int i = 0; i < str.Length; ++i)
                if (char.IsDigit(str[i]))
                    rez += int.Parse(str[i].ToString());
            return rez;
        }

        public static int freakyMethod(string a, string b)
        {
            int firstSum = findSumOfAllDigids(a);
            int secondSum = findSumOfAllDigids(b);
            return firstSum - secondSum;
        }
    }
}
