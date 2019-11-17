using System;
using System.Collections.Generic;
using System.Text;
using TeamScheduler.Core.DataMappers;
using TeamScheduler.Core.DTO;

namespace TeamScheduler.Core.Services
{
    public class UserService
    {
        private IUserDataMapper UserDataMapper { get; }

        public UserService(IUserDataMapper userDataMapper)
        {
            UserDataMapper = userDataMapper;
        }

        public UserProfileViewModel GetUser(int id)
        {
            var user = UserDataMapper.Get(id);
            return new UserProfileViewModel(user);
        }
    }
}
