using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman
{
    public class User
    {
        public static string username = "";
        public static int point;

        //set value point
        public void setPoint(int point) => _ = point;

        //set value username
        public void setUsername(string username) => _ = username;

        //get value point
        public int getPoint() => point;

        //get value username
        public string getUsername() => username;

    }
}
