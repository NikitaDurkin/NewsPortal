using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NewsPortal.News.Domain.Models;

namespace NewsPortal.News.Domain.Interfaces
{
    /// <summary>
    /// Сервис по работе с новостями
    /// </summary>
    public interface IPublicationsService
    {
        /// <summary>
        /// Получение всех новостей
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<PublicationsViewModel>> GetAll();

        /// <summary>
        /// Получение одной новости
        /// </summary>
        /// <param name="guid">Уникальный идентификатор новости</param>
        /// <returns></returns>
        Task<PublicationsViewModel> Get(Guid guid);

        /// <summary>
        /// Добавление новости
        /// </summary>
        /// <param name="publicationsCreateModel">Модель добавления новости</param>
        /// <returns></returns>
        Task<Guid> Create(PublicationsCreateModel publicationsCreateModel);

        /// <summary>
        /// Изменение новости
        /// </summary>
        /// <param name="publicationsUpdateModel">Модель изменеия новости</param>
        /// <returns></returns>
        Task<Guid> Update(PublicationsUpdateModel publicationsUpdateModel);

        /// <summary>
        /// Удаление новости
        /// </summary>
        /// <param name="guid">Уникальный идентификатр новости</param>
        /// <returns></returns>
        Task Delete(Guid guid);
    }
}