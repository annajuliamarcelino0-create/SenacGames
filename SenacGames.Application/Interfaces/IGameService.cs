using SenacGames.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace SenacGames.Application.Interfaces
{
    /// <summary>
    ///     contrato de serviço de games.
    ///     define as operaçoes de negocio disponiveis para os games.
    /// </summary>
     public interface IGameService
    {
        Task<IEnumerable<GameDto>> GetALLAsync();
        Task<GameDto?> GetByIdAsync(int id);
        Task<IEnumerable<GameDto>> GetFeatureAsync();
        Task<IEnumerable<GameDto>> GetByCategoryAsync(int categoryId);
        Task<GameDto> CreateAsync(CreateGameDto Dto);
        Task<GameDto?> updateasync(int id, updateGameDto Dto);
        Task<bool> DeleteAsync(int id);
        Task<int> CountAsync();
    }
}
