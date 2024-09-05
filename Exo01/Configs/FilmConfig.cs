using Exo01.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo01.Configs
{
    internal class FilmConfig : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            builder.HasKey(e => e.FilmId);
            builder
                .Property(e => e.FilmId)
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder
                .Property(e => e.Titre)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .HasIndex(e => e.Titre)
                .IsUnique();

            builder
                .Property(e => e.AnneeSortie)
                .IsRequired();

            builder.ToTable(t => t.HasCheckConstraint("CK_Film_AnneeSortie", "[AnneeSortie] > 1975"));

            builder
                .Property(e => e.Realisateur)
                .HasMaxLength(100)
                .IsRequired();
            builder
                .Property(e => e.ActeurPrincipal)
                .HasMaxLength(100)
                .IsRequired();
            builder
                .Property(e => e.Genre)
                .HasMaxLength(100)
                .IsRequired();

        }
    }
}
