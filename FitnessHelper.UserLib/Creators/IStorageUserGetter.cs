using FitnessHelper.UserLib.Models;

namespace FitnessHelper.UserLib.Creators
{
    public interface IStorageUserGetter : INewUserDataGetter
    {
        IUsersStorage UsersStorage { get; set; }
        User LoadUser(string userName);
    }
}