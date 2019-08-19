using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NewsPortal.News.Domain.Interfaces;
using NewsPortal.News.Domain.Models;

namespace NewsPortal.News.API.Controllers
{
    /// <summary>
    /// Контроллер для новостей
    /// </summary>
    [Route("api/news")]
    [ApiController]
    [Authorize]
    public class PublicationsController : Controller
    {
        private readonly IPublicationsService _publicationsService;

        public PublicationsController(IPublicationsService publicationsService)
        {
            _publicationsService = publicationsService;
        }

        /// <summary>
        /// Получение всех новостей
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAll")]
        public async Task<IEnumerable<PublicationsViewModel>> GetAll()
        {
            return await _publicationsService.GetAll();
        }

        /// <summary>
        /// Получение одной новости
        /// </summary>
        /// <param name="guid">Уникальный идентификатор новости</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<PublicationsViewModel> Get(Guid guid)
        {
            return await _publicationsService.Get(guid);
        }

        /// <summary>
        /// Добавление новости
        /// </summary>
        /// <param name="publicationsCreateModel">Модель добавления новости</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<Guid> Create([FromBody] PublicationsCreateModel publicationsCreateModel)
        {
            return await _publicationsService.Create(publicationsCreateModel);
        }

        /// <summary>
        /// Редактрирование новости
        /// </summary>
        /// <param name="publicationsUpdateModel">Модель изменеия новости</param>
        /// <returns></returns>
        [HttpPut]
        public async Task<Guid> Update([FromBody] PublicationsUpdateModel publicationsUpdateModel)
        {
            return await _publicationsService.Update(publicationsUpdateModel);
        }

        /// <summary>
        /// Удаление новости
        /// </summary>
        /// <param name="guid">Уникальный идентификатор новости</param>
        /// <returns></returns>
        [HttpDelete]
        public async Task Delete(Guid guid)
        {
            await _publicationsService.Delete(guid);
        }
    }
}