using ExamenOnlineGokken.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenOnlineGokken.ViewModels
{
    public class HomeFindByLeagueVM
    {
        public string LeagueName { get; set; }
        public long GameId { get; set; }
        public List<Game> Games { get; set; } = new List<Game>();
    }
}
