using System;

namespace NewsPortal.News.Domain.Models
{
    /// <summary>
    /// Модель добавления новости
    /// </summary>
    public class PublicationsCreateModel
    {
        /// <summary />
        public PublicationsCreateModel()
        {
        }

        /// <summary>
        /// Уникальный идентификатор новости
        /// </summary>
        private Guid Guid { get; set; }

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