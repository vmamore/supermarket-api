using AutoMapper;
using src.Domain.Models;
using src.Resource;

namespace src.Mapping
{
  public class ResourceToModelProfile : Profile
  {
    public ResourceToModelProfile()
    {
        CreateMap<SaveCategoryResource, Category>();
    }
  }
}