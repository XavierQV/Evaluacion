using Evaluacion.Data;
using Evaluacion.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace Evaluacion.Controllers
{
    public class SociosController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public SociosController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        // GET: SocioController
        public ActionResult Index()
        {
            List<SocioViewModel> socios = new List<SocioViewModel>();
            socios = _applicationDbContext.Socios.Select(q => new SocioViewModel
            {
                Cedula=q.Cedula,
                Nombre = q.Nombre,
                Apellido = q.Apellido,
                Direccion = q.Direccion,
                Estado = q.Estado,                
            }).ToList();

            return View(socios);
        }

        // GET: SocioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SocioController/Create
        public ActionResult Create()
        {
           
            return View();
        }

        // POST: SocioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: SocioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SocioController/Edit/5
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

        // GET: SocioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SocioController/Delete/5
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
