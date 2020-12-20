using AutoMapper;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiExample.DataTransferObjects;

namespace WebApiExample.Profiles
{
    public class UserProfile: Profile
    {
        public UserProfile()
        {
            CreateMap<Users, UserDTO>();

        }
    }
}
