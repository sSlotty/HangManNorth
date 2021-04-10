using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman.Services
{
    interface IUserService
    {
        public string GetUsername();
        public void SetUsername(string username);
        public int GetUserScore();
        public void SetUserScore(int score);
    }
}
