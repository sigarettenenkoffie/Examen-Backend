using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenOnlineGokken.ViewModels
{
    public class GameAddGameVM
    {
        [Required]
        public string HomeTeam { get; set; }
        [Required]
        public string AwayTeam { get; set; }
        public long LeagueId { get; set; }
        public List<SelectListItem> Leagues { get; set; } = new List<SelectListItem>();
    }
}
