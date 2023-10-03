﻿using DreamCrusher.Models;
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
        public ActionResult ProductServies()
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