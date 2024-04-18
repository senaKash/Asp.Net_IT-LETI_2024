using Board.Contracts.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Board.Application.AppData.Posts.Services
{
    /// <summary>
    /// Сервисы по работе с объявлениями
    /// </summary>
    public interface IPostService
    {
        /// <summary>
        /// Создает объявление
        /// </summary>
        /// <param name="dto">Модель создания объявления</param>
        /// <param name="cancellationToken">Токен отмены операции</param>
        /// <returns>Модель объявления </returns>
        Task<CreatePostDto> AddPost(CreatePostDto dto, CancellationToken cancellationToken);

    }
}
