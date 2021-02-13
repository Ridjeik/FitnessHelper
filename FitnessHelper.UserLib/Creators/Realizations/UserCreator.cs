using FitnessHelper.UserLib.Creators.Interfaces;
using FitnessHelper.UserLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessHelper.UserLib.Creators.Realizations
{
    class UserCreator : IUserCreator
    {
        public IStorageManipulator StorageManipulator { get; }
        public INewUserDataGetter NewDataGetter { get; }

        //TODO: Add checking into properties.

        public User CreateUser(string userName)
        {
            if(StorageManipulator.LoadUser(userName) is User user)
            {
                return user;
            }
            else
            {
                var gender = NewDataGetter.GetGender();
                var birthDate = NewDataGetter.GetBirthDate();
                var weight = NewDataGetter.GetWeight();
                var height = NewDataGetter.GetHeight();
                var newUser = new User(userName, gender, birthDate, weight, height);
                StorageManipulator.SaveUser(newUser);
                return newUser;
            }
        }

        public UserCreator(IStorageManipulator storageManipulator, INewUserDataGetter newDataGetter)
        {
            StorageManipulator = storageManipulator ?? throw new ArgumentNullException(nameof(storageManipulator));
            NewDataGetter = newDataGetter ?? throw new ArgumentNullException(nameof(newDataGetter));
        }
    }
}
