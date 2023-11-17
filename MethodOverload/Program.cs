namespace MethodOverload
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var Overload = new OverloadTest();
            Overload.PrintMessage("Hei på deg!", 200);
            Overload.PrintMessage("Hvordan går det?", "Bare bra takk!");
        }
    }
}