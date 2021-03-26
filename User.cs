using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman
{
    class User
    {
        string username = null;
        int point = 0;

        public void setPoint(int point)
        {
            this.point = point;
        }

        public void setUsername(string username)
        {
            this.username = username;
        }
        public int getPoint()
        {
            return this.point;
        }

        public string getUsername()
        {
            return this.username;
        }

    }
}
