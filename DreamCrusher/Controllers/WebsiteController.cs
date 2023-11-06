using DreamCrusher.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DreamCrusher.Controllers
{
    public class WebsiteController : Controller
    {
        // GET: Website
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult about()
        {
            return View();
        }
        public ActionResult contact()
        {
            return View();
        }
        public ActionResult Savecontactus(Website obj)
        {
            string FormName = "";
            string Controller = "";
            try
            {
                DataSet ds = obj.Savecontactus();
                if (ds != null && ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows[0][0].ToString() == "1")
                    {
                        TempData["Savecontactus"] = "Contact details saved successfully !!";
                        FormName = "contact";
                        Controller = "Website";
                    }
                    else if(ds.Tables[0].Rows[0][0].ToString() == "0")
                    {
                        TempData["Errcontactus"] = ds.Tables[0].Rows[0]["ErrorMessage"].ToString();
                        FormName = "contact";
                        Controller = "Website";
                    }
                    else
                    {
                        TempData["Errcontactus"] = ds.Tables[0].Rows[0]["ErrorMessage"].ToString();
                        FormName = "contact";
                        Controller = "Website";
                    }
                }
                else
                {
                    TempData["Errcontactus"] = ds.Tables[0].Rows[0]["ErrorMessage"].ToString();
                    FormName = "contact";
                    Controller = "Website";
                }
            }
            catch (Exception ex)
            {
                TempData["Errcontactus"] = ex.Message;
                FormName = "contact";
                Controller = "Website";
            }
            return RedirectToAction(FormName, Controller);
        }

        public ActionResult ProductServies(Website model)
        {
            List<Website> lst = new List<Website>();
            DataSet ds = model.ProductandServicesList();

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    Website obj = new Website();
                    obj.ProductName = r["ProductName"].ToString();
                    obj.ProductPrice = r["Amount"].ToString();
                    obj.Image = r["Image"].ToString();
                    lst.Add(obj);
                }
                model.lstproductandServices = lst;
            }
            return View(model);
        }

        public ActionResult OurBankers()
        {
            return View();
        }
        //public ActionResult HighestEarnerClub()
        //{
        //    return View();
        //}
        public ActionResult HighestEarnerClub()
        {
            Home model = new Home();
            List<Home> list = new List<Home>();
            DataSet ds = model.GetHighestEarnerList();
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    Home obj = new Home();
                    //obj.FK_UserId = r["FK_UserId"].ToString();
                    //  obj.LoginId = r["LoginId"].ToString();
                    obj.Name = r["Name"].ToString();
                    obj.ProfilePic = r["ProfilePic"].ToString();
                    obj.GrossAmount = r["GrossAmount"].ToString();
                    // obj.ToDate = r["AddedOn"].ToString();
                    //obj.City = r["City"].ToString();
                    list.Add(obj);
                }
                model.listhighestearner = list;
            }
            return View(model);
        }
        public ActionResult Gallery(Home model)
        {
            List<Home> list = new List<Home>();
            DataSet ds = model.GetGalleryList();
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    Home obj = new Home();
                    obj.PK_GalleryID = r["PK_GalleryID"].ToString();
                    obj.Image = r["Image"].ToString();

                    list.Add(obj);
                }
                model.lstGallery = list;
            }

            return View(model);
        }
        public ActionResult TermCondition()
        {
            return View();
        }
        public ActionResult LegalDocuments()
        {
            return View();
        }
    }
}