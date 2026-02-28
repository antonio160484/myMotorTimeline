using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyMotorTimeline.Data;
using MyMotorTimeline.Models;

namespace MyMotorTimeline.Controllers
{
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

        // GET: VehiculoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VehiculoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VehiculoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Vehiculo vehiculo)
        {
            if (!ModelState.IsValid)
            {
                return View(vehiculo);
            }

          
            var usuarioId = _userManager.GetUserId(User);
            vehiculo.UsuarioId = usuarioId;
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
