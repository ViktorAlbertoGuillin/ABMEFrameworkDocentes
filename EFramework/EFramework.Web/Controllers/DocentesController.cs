using EFramework.Data.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace EFramework.Web.Controllers
{
    public class DocentesController : Controller
    {
        private DocentesContext _contexto;
        public DocentesController(DocentesContext contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Listar()
        {
            var lista = _contexto.Docentes.ToList();
            return View(lista);
        }

        public IActionResult Agregar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Agregar(Docente docente)
        {
            DocentesContext ctx = new DocentesContext();
            ctx.Docentes.Add(docente);
            ctx.SaveChanges();
            var lista = _contexto.Docentes.ToList();
            return View("Listar",lista);
        }

        public IActionResult Eliminar(int Id)
        {
            var docente = _contexto.Docentes.Find(Id);
            if(docente != null)
            {
                _contexto.Remove(docente);
                _contexto.SaveChanges();
            }
            var lista = _contexto.Docentes.ToList();
            return View("Listar", lista);
        }

        public IActionResult Editar(int Id)
        {
            var docente = _contexto.Docentes.Find(Id);
            return View(docente);
        }

        [HttpPost]
        public IActionResult Editar(Docente docente)
        {
            var doc = _contexto.Docentes.Find(docente.Id);
            if (doc != null)
            { 
                doc.Nombre = docente.Nombre;
                doc.Edad = docente.Edad;
                doc.Materia = docente.Materia;
                doc.Ciudad = docente.Ciudad;
                _contexto.SaveChanges();
            }
            var lista = _contexto.Docentes.ToList();
            return View("Listar", lista);
        }
    }
}
