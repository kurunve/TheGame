
using System.Text;

namespace Game.Levels
{
    class Level1
    {
        public static string HelloWorld()
        {
            return "Hello, World!";
        }

        public static string Hello(string user_name)
        {
            bool flag = false;
            string[] mass = user_name.Split(' ');
            string name = "";
            for (int i = 0; i < mass.Length; ++i)
            {
                if (mass[i].ToLower() == mass[i])
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
            if (flag == false)
                return string.Format("{0}, {1}!", "Hello", name.TrimEnd(' '));
            else
            {
                return string.Format("{0}, {1}.", "Hello", name.TrimEnd(' '));
            }
        }

        public static string FizzBuzzTest(int i)
        {
            return string.Empty;
        }
    }
}
