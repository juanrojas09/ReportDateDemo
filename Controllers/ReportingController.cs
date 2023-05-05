using DevExpress.AspNetCore.Reporting.WebDocumentViewer;
using DevExpress.AspNetCore.Reporting.WebDocumentViewer.Native.Services;
using Microsoft.AspNetCore.Mvc;

namespace Prueba_Licencia.Controllers
{
    public class ReportingController : WebDocumentViewerController
    {
        public ReportingController(IWebDocumentViewerMvcControllerService controllerService):base(controllerService)
        {

        }
    }
}
