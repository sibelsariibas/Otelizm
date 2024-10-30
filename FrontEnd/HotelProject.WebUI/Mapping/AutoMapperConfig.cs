using AutoMapper;
using HotelProject.EntityLayer.Concrate;
using HotelProject.WebApi.Dtos.AboutDto;
using HotelProject.WebApi.Dtos.LoginDto;
using HotelProject.WebApi.Dtos.RegisterDto;
using HotelProject.WebApi.Dtos.RoomDto;
using HotelProject.WebApi.Dtos.ServiceDto;
using HotelProject.WebApi.Dtos.StaffDto;
using HotelProject.WebApi.Dtos.SubscribeDto;
using HotelProject.WebApi.Dtos.RezervationDto;

namespace HotelProject.WebUI.Mapping
{
	public class AutoMapperConfig : Profile
	{
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
			CreateMap<UpdateServiceDto, Service>().ReverseMap();
			CreateMap<CreateServiceDto, Service>().ReverseMap();
            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();
            CreateMap<ResultAboutDto, About>().ReverseMap();
			CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();
			CreateMap<ResultRoomDto, Room>().ReverseMap();
			CreateMap<ResultStaffDto, Staff>().ReverseMap();
			CreateMap<CreateRezervationDto, Rezervation>().ReverseMap();
		}
    }
}

