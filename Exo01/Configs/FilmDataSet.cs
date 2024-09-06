using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Exo01.Entities;

namespace Exo01
{
    internal class FilmDataSet : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            builder.HasData(
                new Film
                {
                    FilmId = 1,
                    Titre = "Star Wars : Un nouvel espoir",
                    AnneeSortie = 1977,
                    ActeurPrincipal = "Mark Hammil",
                    Genre = "Science-Fiction",
                    Realisateur = "Georges Lucas"
                },
                new Film
                {
                    FilmId = 2,
                    Titre = "Star Wars : L'empire contre-attaque",
                    AnneeSortie = 1980,
                    ActeurPrincipal = "Mark Hammil",
                    Genre = "Science-Fiction",
                    Realisateur = "Georges Lucas"
                },
                new Film
                {
                    FilmId = 3,
                    Titre = "Star Wars : Le retour du Jedi",
                    AnneeSortie = 1983,
                    ActeurPrincipal = "Mark Hammil",
                    Genre = "Science-Fiction",
                    Realisateur = "Georges Lucas"
                },
                new Film
                {
                    FilmId = 4,
                    Titre = "Hooligans",
                    AnneeSortie = 2005,
                    ActeurPrincipal = "Charlie Hunnam",
                    Genre = "Société",
                    Realisateur = "Lexi Alexander"
                },
                new Film
                {
                    FilmId = 5,
                    Titre = "LOTR - La communauté de l'anneau",
                    AnneeSortie = 2001,
                    ActeurPrincipal = "Elijah Wood",
                    Genre = "Heroic-Fantasy",
                    Realisateur = "Peter Jackson"
                },
                new Film
                {
                    FilmId = 6,
                    Titre = "LOTR - Les deux tours",
                    AnneeSortie = 2002,
                    ActeurPrincipal = "Elijah Wood",
                    Genre = "Heroic-Fantasy",
                    Realisateur = "Peter Jackson"
                },
                new Film
                {
                    FilmId = 7,
                    Titre = "LOTR - Le retour du roi",
                    AnneeSortie = 2003,
                    ActeurPrincipal = "Elijah Wood",
                    Genre = "Heroic-Fantasy",
                    Realisateur = "Peter Jackson"
                }
                );
        }
    }
}
