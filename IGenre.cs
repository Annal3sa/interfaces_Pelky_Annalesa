using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces_Pelky_Annalesa
{
    interface IGenre
    {

        public string Esrb { get; set; }

        public string Genre { get; set; }

        public string Title { get; set; }

        public string Describe();

    }
}
