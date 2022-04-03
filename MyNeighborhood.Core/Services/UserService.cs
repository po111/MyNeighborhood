﻿using Microsoft.EntityFrameworkCore;
using MyNeighborhood.Core.Contracts;
using MyNeighborhood.Core.Models;
using MyNeighborhood.Infrastructure.Data.Identity;
using MyNeighborhood.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNeighborhood.Core.Services
{
    public class UserService : IUserService
    {

        private readonly IApplicationDbRepository repo;

        public UserService(IApplicationDbRepository _repo)
        {
            repo = _repo;
        }

        public async Task<ApplicationUser> GetUserById(string id)
        {
            return await repo.GetByIdAsync<ApplicationUser>(id);
        }

        public async Task<UserEditViewModel> GetUserForEdit(string id)
        {
            var user= await repo.GetByIdAsync<ApplicationUser>(id);

            return new UserEditViewModel() 
            { 
                Id=user.Id,
                FirstName= user.FirstName, 
                LastName = user.LastName 
            };
        }

        public async Task<IEnumerable<UserListViewModel>> GetUsers()
        {
            return await repo.All<ApplicationUser>()
                .Select(u => new UserListViewModel()
                {
                    Email = u.Email,
                    Id = u.Id,
                    Name = $"{u.FirstName} {u.LastName}",
                })
                .ToListAsync();
        }

        public async Task<bool> UpdateUser(UserEditViewModel model)
        {
            bool result = false;

            var user = await repo.GetByIdAsync<ApplicationUser>(model.Id);
            
            if (user != null)
            {
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;

                await repo.SaveChangesAsync();

                result = true;
            }

            return result;
        }
    }
}
