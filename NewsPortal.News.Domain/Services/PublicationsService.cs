using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NewsPortal.News.Database;
using NewsPortal.News.Database.Models;
using NewsPortal.News.Domain.Interfaces;
using NewsPortal.News.Domain.Models;

namespace NewsPortal.News.Domain.Services
{
    /// <inheritdoc/>
    public class PublicationsService : IPublicationsService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public PublicationsService(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<PublicationsViewModel>> GetAll()
        {
            var result = await _context.Publications.ToListAsync();
            return _mapper.Map<List<Publications>, List<PublicationsViewModel>>(result);
        }

        /// <inheritdoc/>
        public async Task<PublicationsViewModel> Get(Guid guid)
        {
            var result = await _context.Publications.FindAsync(guid);
            return _mapper.Map<PublicationsViewModel>(result);
        }

        /// <inheritdoc/>
        public async Task<Guid> Create(PublicationsCreateModel publicationsCreateModel)
        {
            var result = _mapper.Map<Publications>(publicationsCreateModel);
            _context.Publications.Add(result);
            await _context.SaveChangesAsync();
            return result.Guid;
        }

        /// <inheritdoc/>
        public async Task<Guid> Update(PublicationsUpdateModel publicationsUpdateModel)
        {
            var result = await _context.Publications.FirstOrDefaultAsync(a => a.Guid == publicationsUpdateModel.Guid);

            result.Title = publicationsUpdateModel.Title;
            result.Info = publicationsUpdateModel.Info;

            _context.Publications.Update(result);
            await _context.SaveChangesAsync();
            return result.Guid;
        }

        /// <inheritdoc/>
        public async Task Delete(Guid guid)
        {
            var result = await _context.Publications.FindAsync(guid);
            _context.Publications.Remove(result);
            await _context.SaveChangesAsync();
        }
    }
}