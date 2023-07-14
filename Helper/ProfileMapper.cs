using AutoMapper;
using movieAPI.DTOs;

namespace movieAPI.Helper
{
    public class ProfileMapper : Profile
    {
        public ProfileMapper()
        {
            CreateMap<Movie, Moviedto>();
            CreateMap<Moviedto,Movie>()
                .ForMember(src => src.Poster, opt => opt.Ignore());
        }

    }
}
