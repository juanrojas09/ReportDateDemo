using DevExpress.XtraRichEdit.Model;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Prueba_Licencia.Models;
using Prueba_Licencia.report;
using System.Diagnostics;

namespace Prueba_Licencia.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            DateTime InitDate = new DateTime(2022, 6, 10);
            DateTime EndDate = new DateTime(2023,  3, 28);

            //instancio el reporte para setearle los valores y datos
            var ReporteHijo = new XtraReport1();
            ReporteHijo.Parameters["InitDate"].Value = InitDate;
            ReporteHijo.Parameters["EndDate"].Value = EndDate;
            ReporteHijo.Parameters["InitDate"].Visible = false;
            ReporteHijo.Parameters["EndDate"].Visible = false;
            //ViewBag.Report = xtraReport3;
            //instancio el modelo a pasar a la vista y le asigno los valores correspondientes



            ViewBag.startDate = InitDate;
            ViewBag.endDate = EndDate;
            ViewBag.ReporteHijo = ReporteHijo;


          
            return View();
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
        public IActionResult PayView2(DateTime InitDate, DateTime EndDate)
        {
             InitDate = new DateTime(2022, 1, 1);
            EndDate = new DateTime(2023, 1, 1);

            //instancio el reporte para setearle los valores y datos
            var ReporteHijo = new XtraReport1();
            ReporteHijo.Parameters["InitDate"].Value = InitDate;
            ReporteHijo.Parameters["EndDate"].Value = EndDate;
            ReporteHijo.Parameters["InitDate"].Visible = false;
            ReporteHijo.Parameters["EndDate"].Visible = false;
            //ViewBag.Report = xtraReport3;
            //instancio el modelo a pasar a la vista y le asigno los valores correspondientes



            ViewBag.startDate = InitDate;
            ViewBag.endDate = EndDate;
            ViewBag.ReporteHijo = ReporteHijo;


            return View();
        }

    }
}