

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
            return string.Format("{0}, {1}!", "Hello",user_name);
        }

        public static string FizzBuzzTest(int i)
        {
            return string.Empty;
        }
    }
}
