using AutoMapper;
using Commander.Models;
using Commander.Dtos;

namespace Commander.Profiles
{
    public class CommanderProfiles : Profile
    {
        public CommanderProfiles()
        {
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
            CreateMap<Command, CommandUpdateDto>();
        }
    }
}
