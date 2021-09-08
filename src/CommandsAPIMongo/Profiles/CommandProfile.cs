using AutoMapper;
using CommandsAPIMongo.Dtos;
using CommandsAPIMongo.Models;

namespace CommandsAPIMongo.Profiles
{
    public class CommandProfile:Profile
    {
        public CommandProfile()
        {
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
            CreateMap<Command, CommandUpdateDto>();
        }
    }
}