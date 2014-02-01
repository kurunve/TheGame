
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

        public static string StringReverse(string a, string b)
        {
            return string.Empty;
        }
    }
}
