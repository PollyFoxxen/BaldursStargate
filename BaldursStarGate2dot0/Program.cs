namespace BaldursStarGate2dot0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(20, 20);
            Console.SetBufferSize(20, 20);
            Console.Clear();
            new Menu();
        }
    }
}