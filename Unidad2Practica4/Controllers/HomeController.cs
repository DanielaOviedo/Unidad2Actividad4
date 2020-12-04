using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Unidad2Practica4.Models;

namespace Unidad2Practica4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            mapa_curricularContext context = new mapa_curricularContext();
            var carreras = context.Carreras.OrderBy(x => x.Nombre);
            return View(carreras);
        }
        [Route("{id}")]
        public IActionResult Informacion( string id)
        {
            mapa_curricularContext context = new mapa_curricularContext();
            var nombre = id.Replace("-", " ").ToLower();
            var carrera = context.Carreras.FirstOrDefault(x => x.Nombre.ToLower() == nombre);
            if (carrera==null)
            {
                return RedirectToAction("Index");
            }
            else
            return View(carrera);
        }
        [Route("(id)/Reticula")]
        public IActionResult Reticula(string id)
        {
            var nombre = id.Replace("-", " ").ToUpper();
            mapa_curricularContext context = new mapa_curricularContext();
            var carrera = context.Carreras.Include(x=>x.Materias)
                .FirstOrDefault(x => x.Nombre.ToUpper() == nombre);
            if (carrera == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ReticulaViewModel vm = new ReticulaViewModel();
                vm.Nombre = carrera.Nombre;
                vm.Plan = carrera.Plan;
                vm.Creditos = carrera.Materias.Sum(x => x.Creditos);
                vm.Materias = new List<Materias>[9];
                vm.Materias = carrera.Materias.OrderBy(x => x.Semestre)
                    .GroupBy(x => x.Semestre).Select(x => x).ToArray();

                return View(vm);

            }
            
            
        }
    }
}
