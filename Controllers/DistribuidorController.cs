using Microsoft.AspNetCore.Mvc;
using T2_Ramos_Cristhian.Distribuidores;
using T2_Ramos_Cristhian.Models;

namespace T2_Ramos_Cristhian.Controllers
{
    public class DistribuidorController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DistribuidorController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Distribuidor> lista = _db.Distribuidor;
            return View(lista);
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(Distribuidor Distribuidor)
        {
            if (ModelState.IsValid)
            {
                _db.Distribuidor.Add(Distribuidor);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(Distribuidor);

        }

        //Get Editar
        public IActionResult Editar(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }

            var obj = _db.Distribuidor.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //Post Editar

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(Distribuidor Distribuidor)
        {
            if (ModelState.IsValid)
            {
                _db.Distribuidor.Update(Distribuidor);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(Distribuidor);
        }

        //Get Eliminar
        public IActionResult Eliminar(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }

            var obj = _db.Distribuidor.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //Post Eliminar

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Eliminar(Distribuidor Distribuidor)
        {
            if (Distribuidor == null)
            {
                return NotFound();
            }

            _db.Distribuidor.Remove(Distribuidor);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}
