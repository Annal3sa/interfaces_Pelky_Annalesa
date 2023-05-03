using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces_Pelky_Annalesa
{
    class Game : IGenre
    {
        public string Esrb { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }

        public Game(string esrbParam, string genreParam, string titleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = titleParam;
        }

        public void Playgame()
        {
            Console.WriteLine($"{Title} is starting! Game ON!");
        }

        public string Describe()
        {
            return $"{Title} is a {Genre} game, rated {Esrb}!";
        }


    }
}
