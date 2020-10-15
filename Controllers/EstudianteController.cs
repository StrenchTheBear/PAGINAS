using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PAGINAS.Models;

namespace PAGINAS.Controllers
{
    public class EstudianteController : Controller
    {

       private readonly ILogger<EstudianteController> _logger;

        public EstudianteController(ILogger<EstudianteController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Estudiante objEstudiante){
            if (ModelState.IsValid)
            {
                objEstudiante.Response = "Registro de Base de Datos (*)";
            }
            return View("index", objEstudiante);
        }

    }
}