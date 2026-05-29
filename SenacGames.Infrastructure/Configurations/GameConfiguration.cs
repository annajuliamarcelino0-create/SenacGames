using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SenacGames.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SenacGames.Infrastructure.Configurations
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasKey(g => g.Id);

            builder.Property(g => g.Title)
                .IsRequired() // dfeine que o campo é obrigatório.
                .HasMaxLength(200);// define o tamanho máximo do campo.

            builder.Property(g => g.Description)
                .HasMaxLength(2000);// define o tamanho máximo do campo.

            builder.Property(g => g.CoverImageUrl)
                .HasMaxLength(500);// define o tamanho máximo do campo.

            builder.HasOne(g => g.Category) // um game tem uma categoria.
                .WithMany(c => c.Games) // uma categoria tem muitos games.
                .HasForeignKey(g => g.CategoryId); // a fk e categoryID
                 .OnDelete(DeleteBehavior.Restrict); 
        }


    }

}
