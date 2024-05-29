using BlogSocialUdla.AccesoDatos.Data.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace BlogSocialUdla.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriasController : Controller
    {
        private readonly IContenedorTrabajo _contenedorTrabajo;
        public CategoriasController(IContenedorTrabajo contenedorTrabajo)
        {
            _contenedorTrabajo = contenedorTrabajo;

        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();

        }
        /* [HttpPost]
         public IActionResult Create()
         {


         }*/
        #region llamadas a la API
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new {data=_contenedorTrabajo.Categoria.GetAll()});

        }
        #endregion
    }
}
