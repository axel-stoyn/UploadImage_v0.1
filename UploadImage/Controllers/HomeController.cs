using MetadataExtractor;
using MetadataExtractor.Formats.Exif;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UploadImage.DateBaseContext;
using UploadImage.Models;

namespace UploadImage.Controllers
{
    public class HomeController : Controller
    {
        private PhotoDbContext db = new PhotoDbContext();

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Files = System.IO.Directory.GetFiles(Server.MapPath("/Files/"));
            return View();
        }

        [HttpPost]
        public ActionResult Create(HttpPostedFileBase upload, AddImage img)
        {
            if (upload != null)
            {
                string fileName = System.IO.Path.GetFileName(upload.FileName);
                if (System.IO.File.Exists((Server.MapPath("/Files/" + fileName))))
                {
                    ViewBag.File = "Filename already exists: " + fileName;
                }
                else
                {
                    if (ModelState.IsValid)
                    {
                        upload.SaveAs(Server.MapPath("/Files/" + fileName));
                        img.ImagePath = fileName;
                        db.Images.Add(img);
                        db.SaveChanges();
                        ViewBag.File = "File uploaded " + fileName;
                    }
                }
            }
            ViewBag.Files = System.IO.Directory.GetFiles(Server.MapPath("/Files/"));
            return View("Index");
        }

        public ActionResult Edit(int? id)
        {
            return PartialView();
        }


        [HttpPost, ActionName("EditPartial")]
        [ValidateAntiForgeryToken]
        public ActionResult EditPost(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var imageToUpdate = db.Images.Find(id);
            if (TryUpdateModel(imageToUpdate, "",
               new string[] { "Description" }))
            {
                try
                {
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                catch (RetryLimitExceededException)
                {
                    ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
                }
            }
            return PartialView(imageToUpdate);
        }
    }
}
