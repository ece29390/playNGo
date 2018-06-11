using PlayNGo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlayNGo.View.Models
{
    public class PlayersModel
    {
        
        public PlayersModel()
        {
            CurrentListOfPlayers = new List<Person>();
            EnableNextPage = true;
            EnablePreviousPage = false;                               
        }

        public int TotalCount { get; set; }
        public List<Person> CurrentListOfPlayers { get; set; }
        public bool EnableNextPage { get; set; }
        public bool EnablePreviousPage { get; set; }
        public IEnumerable<SelectListItem> TableStyles { get;  set; }
        public int CurrentPage { get; set; }
        public string SelectedTableStyle { get; set; }
        
    }
}