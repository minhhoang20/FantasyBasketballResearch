using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApp.Mock;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            var mockGenerator = new MockDataGenerator();
            List<PlayerSeasonStatistics> teamSeasonStats = mockGenerator.GenerateTeamSeasonStats();
            return View(teamSeasonStats);
        }
    }
}