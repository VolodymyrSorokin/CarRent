using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kurs_Sorokin_621pmb_WFA
{
    public static class UserSession
    {
        public static User CurrentUser { get; private set; }
        public static bool IsGuest { get; private set; } = false;

        public static void Login(User user)
        {
            CurrentUser = user;
            IsGuest = false;
        }

        public static void LoginAsGuest()
        {
            CurrentUser = null;
            IsGuest = true;
        }

        public static void Logout()
        {
            CurrentUser = null;
            IsGuest = false;
        }
    }
}
