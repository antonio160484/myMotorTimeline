using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyMotorTimeline.Data;
using MyMotorTimeline.Models;

namespace MyMotorTimeline.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<Usuario> _userManager;
        private readonly MyMotorDbContext _context;

        public HomeController(ILogger<HomeController> logger, UserManager<Usuario> useManager, MyMotorDbContext context)
        {
            _logger = logger;
            _userManager = useManager;
            _context = context;
        }

        
        public async Task <IActionResult> Index()
        {
            var usuarioId = _userManager.GetUserId(User);

            var vehiculos = await _context.Vehiculos
                .Where(v => v.UsuarioId == usuarioId)
                .ToListAsync();
            return View(vehiculos);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
