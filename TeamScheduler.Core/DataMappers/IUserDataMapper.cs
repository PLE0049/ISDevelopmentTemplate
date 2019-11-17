using System;
using System.Collections.Generic;
using System.Text;
using TeamScheduler.Core.DomainModels;

namespace TeamScheduler.Core.DataMappers
{
    public interface IUserDataMapper
    {
        IEnumerable<User> GetAll();
        User Get(int id);
        User Update(User user);
        bool Create(User user);
        bool Delete(User user);
    }
}
