using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman
{
    class User
    {
        public static string username = "";
        public static int point;

        public void setPoint(int point) => _ = point;

        public void setUsername(string username) => _ = username;
        public int getPoint() => point;

        public string getUsername() => username;

    }
}
