using System;
using System.Collections.Generic;
using System.Text;
 // dito de categoria ,para ser usado na hora de cadastrar um jogo,para o usuario selecionar a categoria do jogo 
namespace SenacGames.Application.DTOs
{
 public class CategoryDto
    {
        public int id { get; set; }
        public string name { get; set; } = string.Empty;

        /// <summary>
        /// quantidade de games nesta categoria.
        /// util para mostrar no dashboard e na listagem.
        /// </summary>
        public int GamesCount { get; set; }
    }
    /// <summary>
    ///     DTO para criaçao de uma nova categoria.
    /// </summary>
    public class CreateCategoryDto
    {
        public string Name { get; set; } = string.Empty;
 
   }
    /// <summary>
    /// DTO para atualização de uma categoria existente.
    /// </summary>
    public class UpdateCategoryDto
    {
        public string Name { get; set; } = string.Empty;
    }
}

