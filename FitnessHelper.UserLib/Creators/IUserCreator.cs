using FitnessHelper.UserLib.Models;
namespace FitnessHelper.UserLib.Creators
{
    public interface IUserCreator
    {
        User CreateUser();

        IStorageUserGetter UserGetter { get; }
        IStorageUserSaver UserSaver { get; }
        INewUserDataGetter NewDataGetter { get; }
    }
}