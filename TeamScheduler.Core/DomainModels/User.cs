using System;
using System.Collections.Generic;
using System.Text;
using TeamScheduler.Core.DataMappers;

namespace TeamScheduler.Core.DomainModels
{
    public class User
    {
        // Data
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        private IUserDataMapper UserDataMapper { get; }
        private Lazy<User> _boss;
        public User Boss
        {
            get
            {
                return _boss.Value;
            }
        }

        public User(IUserDataMapper userDataMapper)
        {
            UserDataMapper = userDataMapper;
            _boss = new Lazy<User>(() => GetBoss());
        }

        public User()
        {

        }

        private User GetBoss()
        {
            return UserDataMapper.Get(5);
        }
        // Behavior
        public void PromoteUser()
        {
            //TODO
        }
    }
}
