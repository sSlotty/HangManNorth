using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman.Services
{
    class UserService : IUserService
    {
        private string _username;
        private int _userScore = 0;

        public string GetUsername()
        {
            return string.IsNullOrEmpty(_username) ? string.Empty : _username;
        }

        public int GetUserScore()
        {
            return _userScore;
        }

        public void SetUsername(string username)
        {
            _username = username;
        }

        public void SetUserScore(int score)
        {
            _userScore = score;
        }
    }
}
