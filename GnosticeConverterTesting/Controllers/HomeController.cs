using Gnostice.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GnosticeConverterTesting.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ConvertToPdf()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ConvertToPdf(HttpPostedFileBase file)
        {
            Gnostice.Documents.Framework.ActivateLicense("495D-ED31-5353-EDE4-9969-EEFE-3860-1561-3A5F-0140-5CC2-B121");
            DocumentConverter dc = new DocumentConverter();

            if (file.FileName.EndsWith(".docx"))
            {
                var wordFile = @"N:\New folder\JAHAL Satish.docx";
                string pdfFile = file.FileName.Replace(".docx", ".pdf");
                dc.ConvertToFile(wordFile, @"C:\Users\rakesh\Documents\Gnostice\new\" + pdfFile);
            }
            return View();
        }
    }
}