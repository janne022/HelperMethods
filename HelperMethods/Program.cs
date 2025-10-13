namespace HelperMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] menuOptions = {"First", "Second", "Exit"};
            MenuOptions options = Menu.ReadOption<string, MenuOptions>("What would you like to do?",menuOptions);
        }
    }
}
