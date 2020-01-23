using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamenOnlineGokken.Data;
using ExamenOnlineGokken.Entities;
using ExamenOnlineGokken.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ExamenOnlineGokken.Controllers
{
    public class GameController : Controller
    {
        protected GambleDbContext _gambleDbContext;

        public GameController(GambleDbContext gambleDbContext)
        {
            _gambleDbContext = gambleDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("AddGame")]
        public IActionResult AddGame()
        {
            return View(InitializeSelectLists());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("AddGame")]
        public async Task<IActionResult> AddGame(GameAddGameVM gameAddGameVM)
        {
            //int maxId = _context.Spots.Max(s => s.Id);

            //check the model
            if (!ModelState.IsValid)
            {
                return View(gameAddGameVM);
            }

            //fill the viewmodel
            _gambleDbContext.Games.Add
                (
                    new Game
                    {
                        Hometeam = gameAddGameVM.HomeTeam,
                        AwayTeam = gameAddGameVM.AwayTeam
                    }
                );

            //save async
            await _gambleDbContext.SaveChangesAsync();

            //back to form
            return Redirect("AddNewSpot");
        }

        private GameAddGameVM InitializeSelectLists()
        {
            //declare the viewmodel
            GameAddGameVM gameAddGameVM = new GameAddGameVM();

            //load birds and locations from database
            var leagues = _gambleDbContext.Leagues;

            //fill the lists
            foreach (var league in leagues)
            {
                gameAddGameVM.Leagues.Add
                    (
                        new SelectListItem
                        {
                            Value = $"{league.Id}",
                            Text = $"{league.Name}"
                        }
                    );
            }

            return gameAddGameVM;
        }
    }
}