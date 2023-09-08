namespace BaldursStarGate2dot0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account ac = new Account();
            ac.Amount = 1;
            ac.Amount -= 10;

            Console.CursorVisible = false;
            //Console.SetWindowSize(20, 20);
            //Console.SetBufferSize(20, 20);
            Console.Clear();
            new Menu();
        }
    }
}