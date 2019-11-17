using TeamScheduler.Core.DomainModels;

namespace TeamScheduler.Core.DTO
{
    public class UserProfileViewModel
    {
        public User User { get; }
        public UserProfileViewModel(User user)
        {
            User = user;
        }
    }
}
