using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeCreator.Models;
using ResumeCreator.Helper;

namespace ResumeCreator.Controllers
{
    public class ManualEntryController : Controller
    {
        // GET: ManualEntry
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ViewModel viewModel)
        {
            PdfConverter pdfConverter = new PdfConverter();
            pdfConverter.CreateHtml(viewModel);
            return View();
        }
    }
}