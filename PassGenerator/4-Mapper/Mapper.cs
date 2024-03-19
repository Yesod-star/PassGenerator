using AutoMapper;
using PassGenerator._3_Services;
using PassGenerator._3_Services.Interface;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PassGenerator._4_Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<IPasswordGenService, PasswordGenService>();
        }
    }
}
