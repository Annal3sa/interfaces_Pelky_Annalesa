using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces_Pelky_Annalesa
{
    class Movie : IGenre
    {
        public string Esrb { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }

        public Movie(string esrbParam, string genreParam, string titleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = titleParam;
        }

        public void PlayMovie()
        {
            Console.WriteLine($"{Title} is starting SSsssshhhh");
        }

        public string Describe()
        {
            return $"{Title} is a {Genre} movie, taed {Esrb}!";
        }
    }
}
