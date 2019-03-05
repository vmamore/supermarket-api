using AutoMapper;
using src.Domain.Models;
using src.Extensions;
using src.Resource;

namespace src.Mapping {
    public class ModelToResourceProfile : Profile {
        public ModelToResourceProfile() {
            CreateMap<Category, CategoryResource>();

            CreateMap<Product, ProductResource>()
                .ForMember(src => src.UnitOfMeasurement, opt => opt.MapFrom(src => src.UnitOfMeasurement.ToDescriptionString()));
        }
    }
}