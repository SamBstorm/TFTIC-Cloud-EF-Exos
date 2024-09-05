using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo01.Entities
{
    internal class Film
    {
        public int FilmId { get; set; }
        public string Titre { get; set; }
        public int AnneeSortie { get; set; }
        public string Realisateur { get; set; }
        public string ActeurPrincipal { get; set; }
        public string Genre { get; set; }
    }
}
