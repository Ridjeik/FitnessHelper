using FitnessHelper.UserLib.Models;

namespace FitnessHelper.UserLib.Creators
{
    public interface IStorageUserGetter : INewUserDataGetter
    {
        IUsersStorage UsersStorage { get; }
        User LoadUser(string userName);
    }
}