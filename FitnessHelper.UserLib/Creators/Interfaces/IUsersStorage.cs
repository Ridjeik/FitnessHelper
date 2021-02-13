using FitnessHelper.UserLib.Models;
using System.Collections.Generic;

namespace FitnessHelper.UserLib.Creators.Interfaces
{
    public interface IUsersStorage
    {
        List<User> GetUsers();
        void SaveUser(User user);
    }
}