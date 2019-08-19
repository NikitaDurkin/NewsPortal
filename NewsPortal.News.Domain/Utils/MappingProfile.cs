using AutoMapper;
using NewsPortal.News.Database.Models;
using NewsPortal.News.Domain.Models;

namespace NewsPortal.News.Domain.Utils
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Publications, PublicationsCreateModel>();
            CreateMap<PublicationsCreateModel, Publications>();
            CreateMap<Publications, PublicationsUpdateModel>();
            CreateMap<PublicationsUpdateModel, Publications>();
            CreateMap<Publications, PublicationsViewModel>();
            CreateMap<PublicationsViewModel, Publications>();
        }
    }
}