using System;

namespace NewsPortal.News.Domain.Models
{
    /// <summary>
    /// Модель изменения новости
    /// </summary>
    public class PublicationsUpdateModel
    {
        /// <summary />
        public PublicationsUpdateModel()
        {
        }

        /// <summary>
        /// Уникальный идентификатор новости
        /// </summary>
        public Guid Guid { get; set; }

        /// <summary>
        /// Название новости
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Информация
        /// </summary>
        public string Info { get; set; }
    }
}