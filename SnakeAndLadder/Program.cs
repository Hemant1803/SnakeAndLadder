namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Snake And Ladders");
            Game game = new Game();

            game.StartGame();

        }
    }
}