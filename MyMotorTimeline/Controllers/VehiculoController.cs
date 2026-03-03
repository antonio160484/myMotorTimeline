using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyMotorTimeline.Data;
using MyMotorTimeline.Models;

namespace MyMotorTimeline.Controllers
{
    [Authorize]
    public class VehiculoController : Controller
    {
        private readonly MyMotorDbContext _context;
        private readonly UserManager<Usuario> _userManager;
        public VehiculoController(MyMotorDbContext context, UserManager<Usuario> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        // GET: VehiculoController
        public async Task <IActionResult> Index()
        {

            return View();
        }

        [Authorize]
        // GET: VehiculoController/Details/5
        public async Task <IActionResult> Details(int id)
        {
            var usuarioId = _userManager.GetUserId(User);

            var vehiculo = await _context.Vehiculos
                .Where(v => v.Id == id && v.UsuarioId == usuarioId)
                .Include(v => v.MantenimientosRealizados)
                .Include(v => v.MantenimientosProgramados)
                .FirstOrDefaultAsync();

            if (vehiculo == null)
                return NotFound();
            

            return View(vehiculo);
        }

        // GET: VehiculoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VehiculoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create(Vehiculo vehiculo)
        {
            if (!ModelState.IsValid)
            {
                return View(vehiculo);
            }

            var usuario = await _userManager.GetUserAsync(User);
            if (usuario == null)
            {
                return View(vehiculo);
            }

            vehiculo.UsuarioId = usuario.Id;
            vehiculo.Patente = vehiculo.Patente?.Trim().ToUpper(); // Convertir la patente a mayúsculas

            _context.Add(vehiculo);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }

        // GET: VehiculoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VehiculoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VehiculoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VehiculoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
