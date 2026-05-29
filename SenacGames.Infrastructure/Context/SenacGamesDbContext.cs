using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SenacGames.Domain.Entities;
using SenacGames.Infrastructure.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SenacGames.Infrastructure.Context
{
    public class SenacGamesDbContext : IdentityDbContext
    {
        public SenacGamesDbContext(DbContextOptions<SenacGamesDbContext> options) 
            : base(options)
        {
        }

        /// <summary>
        /// DbSet para a entidade Game. Representa a tabela de jogos no banco de dados.
        /// </summary>
        public DbSet<Game> Games { get; set; }

        /// <summary>
        /// DbSet para a entidade Category. Representa a tabela de categorias no banco de dados.
        /// </summary>
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder  modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new GameConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        }

    }
}
