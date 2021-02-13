using FitnessHelper.UserLib.Models;
using System;

namespace FitnessHelper.UserLib.Creators
{
    public interface INewUserDataGetter
    {
        Gender GetGender();
        DateTime GetBirthDate();
        double GetWeight();
        double GetHeight();
    }
}