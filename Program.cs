using System;

namespace interfaces_Pelky_Annalesa
{
    class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game("E", "FPS", "ZombCube");
            Console.WriteLine(myGame.Describe());
            myGame.Playgame();

            Movie myMovie = new Movie("PG", "Adventure/Comendy", "Sonic the Hedgehog 2");
            Console.WriteLine(myMovie.Describe());
            myMovie.PlayMovie();
        }
    }
}
