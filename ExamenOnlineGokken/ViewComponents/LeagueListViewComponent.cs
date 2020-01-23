using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamenOnlineGokken.Data;
using ExamenOnlineGokken.Entities;
using ExamenOnlineGokken.ViewModels.Components;
using Microsoft.AspNetCore.Mvc;

namespace ExamenOnlineGokken.ViewComponents
{
    [ViewComponent(Name = "LeagueListView")]
    public class LeagueListViewComponent : ViewComponent
    {
        protected GambleDbContext _gambleDbContext;
        private ICollection<NavigationLinkVM> Leagues { get; set; }

        public LeagueListViewComponent(GambleDbContext gambleDbContext)
        {
            _gambleDbContext = gambleDbContext;
            var leagues = _gambleDbContext.Leagues.OrderBy(l => l.Name).ToList();

            Leagues = new List<NavigationLinkVM>();

            foreach (var league in leagues)
            {
                Leagues.Add(new NavigationLinkVM { Text = league.Name, Controller = "Home", Action = "FindByLeague", RouteId = league.Id });
            }
        }
            
        public async Task<IViewComponentResult> InvokeAsync() 
        {
            var leagueLinks = Leagues;
            return View(leagueLinks);
        }
    }
}
