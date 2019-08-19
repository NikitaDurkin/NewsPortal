using System;

namespace NewsPortal.News.Domain.Models
{
    /// <summary>
    /// Модель получения новости
    /// </summary>
    public class PublicationsViewModel
    {
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