using FitnessHelper.UserLib.Models;
namespace FitnessHelper.UserLib.Creators.Interfaces
{
    public interface IUserCreator
    {
        User CreateUser(string userName);

        IStorageManipulator StorageManipulator { get; init; }
        INewUserDataGetter NewDataGetter { get; init; }
    }
}