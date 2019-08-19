using System;
using System.ComponentModel.DataAnnotations;

namespace NewsPortal.News.Database.Models
{
    /// <summary>
    /// Модель новости
    /// </summary>
    public class Publications
    {
        /// <summary>
        /// Уникальный идентификатор новости
        /// </summary>
        [Key]
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