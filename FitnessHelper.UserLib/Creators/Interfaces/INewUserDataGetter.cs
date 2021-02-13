using FitnessHelper.UserLib.Models;
using System;

namespace FitnessHelper.UserLib.Creators.Interfaces
{
    public interface INewUserDataGetter
    {
        Gender GetGender();
        DateTime GetBirthDate();
        double GetWeight();
        double GetHeight();
    }
}