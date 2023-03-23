﻿namespace Tippekupong
{
    internal class Match
    {
        private int _homegoals;
        private int _awaygoals;
        private string _bet;
        public Match(string bet)
        {
            _bet = bet;
        }
        public string Score()
        {
            return _homegoals + " - " + _awaygoals;
        }

        public bool RightBet()
        {
            var result = _homegoals == _awaygoals ? "U" : _homegoals > _awaygoals ? "H" : "B";
            return _bet.Contains(result);
        }
        public void Play()
        {
            for (int i = 0; i < 6; i++)
            {
                var rnd = new Random();
                var teamScore = rnd.Next(9);
                if (teamScore > 4) _homegoals++;
                else _awaygoals++;
            }

        }
    }
}