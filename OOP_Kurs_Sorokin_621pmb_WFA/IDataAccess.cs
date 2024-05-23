using System.Collections.Generic;

namespace OOP_Kurs_Sorokin_621pmb_WFA
{
    public interface IDataAccess<T>
    {
        List<T> LoadUsersFromJson(string path);
        void AddUserToJson(string path, User data);
    }
}