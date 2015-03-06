using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeanerSnow.DataAccess
{
    public static class AutoMapperConfiguration
    {
        public static void ConfigureUserMapping()
        {
            Mapper.CreateMap<User, LeanerSnow.Core.Entities.User>().ReverseMap();
        }
    }
}
