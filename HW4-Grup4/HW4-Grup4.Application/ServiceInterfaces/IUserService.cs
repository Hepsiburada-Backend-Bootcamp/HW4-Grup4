﻿using HW4_Grup4.Application.DTOs;
using System.Threading.Tasks;

namespace HW4_Grup4.Application.ServiceInterfaces
{
    public interface IUserService
    {
        Task<UserDto> GetUserById(int id);
    }
}
