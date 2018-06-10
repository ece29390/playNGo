using PlayNGo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlayNGo.View.Models
{
    public class PlayersModel
    {
        public PlayersModel()
        {
            CurrentListOfPlayers = new List<Person>();
        }

        public int TotalCount { get; set; }
        public List<Person> CurrentListOfPlayers { get; set; }

        public int CurrentPage { get; set; }
    }
}