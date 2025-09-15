using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProgCMCS.Models;

namespace ProgCMCS.Controllers
{
    public class SupportingDocumentsController : Controller
    {
        private static List<SupportingDocument> documents = new List<SupportingDocument>();

        public IActionResult Index()
        {
            return View(documents);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(SupportingDocument doc)
        {
            doc.DocumentID = documents.Count + 1;
            documents.Add(doc);
            return RedirectToAction("Index");
        }
    }
}
