using System.Collections.Generic;
using TeamScheduler.Core.DataMappers;
using TeamScheduler.Core.DomainModels;

namespace TeamScheduler.Infrastructure.DataMappers
{
    public class UserDataMapper : GeneridMapper<User>, IUserDataMapper
    {
        public void GetAllUsersForLocale()
        {
            throw new System.NotImplementedException();
        }
    }
}
