using FitnessHelper.UserLib.Creators.Interfaces;
using FitnessHelper.UserLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessHelper.UserLib.Creators.Realizations
{
    public class StorageManipulator : IStorageManipulator
    {
        private IUsersStorage usersStorage;

        public IUsersStorage UsersStorage
        {
            get
            {
                return usersStorage;
            }
            init
            {
                usersStorage = value ?? throw new ArgumentNullException(nameof(value));
            }
        }

        public StorageManipulator(IUsersStorage usersStorage)
        {
            UsersStorage = usersStorage;
        }

        public User LoadUser(string userName)
        {
            return UsersStorage.GetUsers().SingleOrDefault(user => user.Name == userName);
        }

        public void SaveUser(User user)
        {
            UsersStorage.SaveUser(user);
        }
    }
}
