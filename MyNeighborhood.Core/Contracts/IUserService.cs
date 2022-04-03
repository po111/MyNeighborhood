﻿using MyNeighborhood.Core.Models;
using MyNeighborhood.Infrastructure.Data.Identity;

namespace MyNeighborhood.Core.Contracts
{
    public interface IUserService
    {

        Task<IEnumerable<UserListViewModel>> GetUsers();

        Task<UserEditViewModel> GetUserForEdit(string id);

        Task<bool> UpdateUser(UserEditViewModel model);

        Task<ApplicationUser> GetUserById(string id);

    }
}
