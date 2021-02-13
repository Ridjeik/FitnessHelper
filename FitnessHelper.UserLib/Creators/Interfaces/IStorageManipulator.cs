using FitnessHelper.UserLib.Models;

namespace FitnessHelper.UserLib.Creators.Interfaces
{
    public interface IStorageManipulator
    {
        IUsersStorage UsersStorage { get; set; }
        User LoadUser(string userName);
        void SaveUser(User user);
    }
}