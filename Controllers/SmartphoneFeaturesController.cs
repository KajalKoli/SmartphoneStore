 using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SmartphoneShop.Models;
using System.IO;

namespace SmartphoneShop.Controllers
{
    public class SmartphoneFeaturesController : Controller
    {
        private SmartphoneContext db = new SmartphoneContext();
       
        // GET: SmartphoneFeatures
        public ActionResult Index()
        {
            List<SmartphoneFeature> SmartphoneList = db.SmartphoneFeatures.ToList().OrderByDescending(y => y.Rating).Take(5).ToList();
            if (User.IsInRole("admin"))
                return View("Admin_Index", SmartphoneList);
            return View(SmartphoneList);

        }

        // GET: Add a new smartphone to list 
        [Authorize(Roles = "admin")]
        public ActionResult Create()
        {

            return View();
        }        

        [HttpPost]
        [Authorize(Roles = "admin")]
        public ActionResult Create(SmartphoneFeature smartphone,HttpPostedFileBase Imageup)
        {
            if (smartphone != null)
            {
                if (Imageup != null)
                {
                    Imageup.SaveAs(Server.MapPath("/")+ "/Content/Image/" + Imageup.FileName);
                    smartphone.Image = "~/Content/Image/" + Imageup.FileName;
                }
                db.SmartphoneFeatures.Add(smartphone);
            }
                db.SaveChanges();
            return RedirectToAction("SmartphoneList", "SmartphoneFeatures");
        }

        [Authorize(Roles = "admin")]
        public ActionResult Edit(Int16 id)
        {
            var smartPhone = db.SmartphoneFeatures.Where(s => s.MobileId == id).FirstOrDefault();
            return View(smartPhone);
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public ActionResult Edit(SmartphoneFeature smartphone,HttpPostedFileBase Imageup)
        {

            if(smartphone.MobileId == 0)
            {
                db.SmartphoneFeatures.Add(smartphone);
            }
            else
            {
                var smartPhone = db.SmartphoneFeatures.Where(s => s.MobileId == smartphone.MobileId).FirstOrDefault();
                smartPhone.Brand = smartphone.Brand;
                smartPhone.Model = smartphone.Model;
                smartPhone.Rating = smartphone.Rating;
                smartPhone.Price = smartphone.Price;
                smartPhone.ScreenSize = smartphone.ScreenSize;
                smartPhone.RAM = smartphone.RAM;
                smartPhone.InternalStorage = smartphone.InternalStorage;
                smartPhone.FrontCamera = smartphone.FrontCamera;
                smartPhone.RearCamera = smartphone.RearCamera;
                smartPhone.OS = smartphone.OS;
                smartPhone.Sim = smartphone.Sim;
                smartPhone.Sensor = smartphone.Sensor;
                smartPhone.BatteryCapacity = smartphone.BatteryCapacity;
                smartPhone.Color = smartphone.Color;
                if (Imageup != null)
                {
                    Imageup.SaveAs(Server.MapPath("/")+ "/Content/Image/" + Imageup.FileName);
                    smartphone.Image = "~/Content/Image/" + Imageup.FileName;
                    smartPhone.Image = smartphone.Image;
                }
            }

            db.SaveChanges();
            return RedirectToAction("SmartphoneList", "SmartphoneFeatures");
        }

        [Authorize(Roles = "admin")]
        public ActionResult Delete(Int16? id)
        {
            if(id == null)
    {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SmartphoneFeature smartphone = db.SmartphoneFeatures.Find(id);
            if (smartphone == null)
            {
                return HttpNotFound();
            }
            db.SmartphoneFeatures.Remove(smartphone);
            db.SaveChanges();

            return RedirectToAction("SmartphoneList", "SmartphoneFeatures");
        }

       


        // GET: SmartphoneFeatures/Details/5
        public ActionResult Details(Int16 id)
        {
            ViewBag.Message = "Order Placed Successfully !!! Your Bill Amount is Rs. ";
            if (id <= 0)
            {  
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SmartphoneFeature smartphoneFeature = db.SmartphoneFeatures.Find(id);
            if (smartphoneFeature == null)
            {
                return HttpNotFound();
            }

            if (User.IsInRole("admin"))
                return View("AdminDetails", smartphoneFeature);
            return View(smartphoneFeature);
        }
       
        public ActionResult SmartphoneList()
        {
            var phoneList = db.SmartphoneFeatures.ToList();
            if (User.IsInRole("admin"))
                return View("AdminList",phoneList);
            return View("Filter",phoneList);
        }

        public ActionResult BrandFilter()
        {

            var phoneList = db.SmartphoneFeatures.ToList();
            List<SmartphoneFeature> brands = phoneList.GroupBy(m => m.Brand).Select(c => c.First()).ToList();
            return View(brands);
        }
        [HttpPost]
        public ActionResult BrandBasedModels(string brand)
        {
            var phoneList = db.SmartphoneFeatures.ToList();
            List<SmartphoneFeature> brands = new List<SmartphoneFeature>();
            foreach (SmartphoneFeature item in phoneList)
            {
                if (item.Brand == brand)
                {
                    brands.Add(item);
                }
            }
            return View("Filter", brands); 
            
        }

       /* public ActionResult BrandFilterTest()
        {
           
            var mobileList = db.SmartphoneFeatures.ToList();
            List<SmartphoneFeature> brands = mobileList.OrderBy(ob => ob.Brand).ToList();


            return View("Filter", brands);
        }
        */
        public ActionResult LowToHigh()
        {
            var mobileList = db.SmartphoneFeatures.ToList();
            List<SmartphoneFeature> filteredList = mobileList.OrderBy(ob => ob.Price).ToList();
            return View("Filter",filteredList);
        }

        public ActionResult HighToLow()
        {
            var mobileList = db.SmartphoneFeatures.ToList();
            List<SmartphoneFeature> filteredList = mobileList.OrderByDescending(ob => ob.Price).ToList();
            return View("Filter",filteredList);
        }
        //
        public ActionResult Filter(List<SmartphoneFeature> mobileList)
        {
            List<SmartphoneFeature> phoneList=new List<SmartphoneFeature>();
            phoneList = mobileList;
            return View(phoneList);
        } 

        public ActionResult Compare()
        {
            var mobileList = db.SmartphoneFeatures.ToList();
            ViewBag.CompareList = new SelectList(mobileList, "Model", "Model");
            return View(); 
        }

        [HttpPost]
        public ActionResult Compare(string mobile1, string mobile2, string compareType)
        {
            string phone1 = mobile1;
            string phone2 = mobile2;
            var mobileList = db.SmartphoneFeatures.ToList();
            List<SmartphoneFeature> compareList = new List<SmartphoneFeature>();
            if (phone1 == phone2)
            {
                ViewBag.Message = "Please choose two different mobiles to compare!!!";
               
            }
          
                foreach (SmartphoneFeature item in mobileList)
                {
                    if (phone1 == item.Model)
                    {
                        compareList.Add(item);
                    }
                    else if (phone2 == item.Model)
                    {
                        compareList.Add(item);
                    }
                }
                if (compareType == "Compare Battery Capacity and Price")
                {
                    return View("Comparison1", compareList);
                }
                else if (compareType == "Compare Internal Storage and RAM")
                {
                    return View("Comparison2", compareList);
                }
                else

                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
              
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
