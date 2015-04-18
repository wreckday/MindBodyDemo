﻿using MindBodyDemo.Models.BL;
using MindBodyDemo.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MindBodyDemo.Controllers
{
    public class StaffController : Controller
    {
        //
        // GET: /Staff/

        public ActionResult Index()
        {
            //ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            IMindBodyDemoBL bl = new MindBodyDemoBL();
            var model = bl.GetCompanyStaff();
            return View(model);
        }

        //
        // GET: /Staff/Appointment/

        public ActionResult Appointment(string firstName, string lastName, string staffId)
        {
            IMindBodyDemoBL bl = new MindBodyDemoBL();
            var model = bl.GetStaffAppointments(firstName, lastName, staffId);
            return View(model);
        }


        //
        // GET: /Staff/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Staff/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Staff/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Staff/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Staff/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Staff/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Staff/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}