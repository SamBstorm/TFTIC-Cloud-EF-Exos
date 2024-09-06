using Exo01.Entities;

namespace Exo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ajout
            Film pacificRim = new Film() { 
                Titre = "Pacific Rim",
                ActeurPrincipal = "Charlie Hunnam",
                Realisateur = "Guillermo Del Toro",
                AnneeSortie = 2013,
                Genre = "Action"
            };

            using (DataContext dc = new DataContext())
            {
                dc.Films.Add(pacificRim);
                dc.SaveChanges();
            }*/

            /*Lecture
            Film[] films;
            using (DataContext dc = new DataContext())
            {
                films = dc.Films
                    .Where(f => f.AnneeSortie < 2001)       //ATTENTION : méthode différée :
                                                            //résultat inaccessible en dehors du contexte

                    .ToArray();                             //ToArray() ou ToList() :
                                                            //Méthode à résultat immédiat :
                                                            //Contourne le problème des méthodes
                                                            //à résultat différé
            }
            foreach (Film film in films)
            {
                Console.WriteLine($"{film.Titre} sorti en  {film.AnneeSortie} réalisé par {film.Realisateur} est un film de/d' {film.Genre} porté par l'acteur {film.ActeurPrincipal}.");
            }*/

            /*Mettre à jour
            using (DataContext dc = new DataContext())
            {
                IEnumerable<Film> films = dc.Films.Where(f => f.Titre.Contains("Star Wars"));
                foreach (Film film in films)
                {
                    film.ActeurPrincipal = "Harrison Ford";
                }
                dc.SaveChanges();
            }*/

            /*Suppression
            using (DataContext dc = new DataContext())
            {
                //dc.RemoveRange(dc.Films.Where(f => f.ActeurPrincipal == "Charlie Hunnam"));
                foreach (Film f in dc.Films.Where(f => f.ActeurPrincipal == "Charlie Hunnam"))
                {
                    dc.Remove(f);
                }
                dc.SaveChanges();
            }*/
        }
    }
}
