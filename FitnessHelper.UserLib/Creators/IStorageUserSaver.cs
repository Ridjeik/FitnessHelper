using FitnessHelper.UserLib.Models;

namespace FitnessHelper.UserLib.Creators
{
    public interface IStorageUserSaver
    {
        IUsersStorage UsersStorage { get; }

        void SaveUser(User user);
    }
}
