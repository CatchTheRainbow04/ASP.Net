﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDTD_Lab04_2.Models;

namespace TDTD_Lab04_2.Controllers
{
    public class TDTDCustomerController : Controller
    {
        // GET: TDTDCustomer
        //khai báo biến CustomerRepository
        static TDTDCustomerRepository listCustomer;
        public TDTDCustomerController()
        {
            //khởi tạo CustomerRepository
            listCustomer = new TDTDCustomerRepository();
        }
        // GET: /Customer/GetCustomers
        public ActionResult GetCustomers()
        {
            return View(listCustomer.GetCustomers());
        }
        //POST: /Customer/GetCustomers
        [HttpPost]
        public ActionResult GetCustomers(string name)
        {
            return View(listCustomer.SearchCustomer(name));
        }
        // GET: /Customer/Details/5
        public ActionResult Details(string id)
        {
            return View(listCustomer.GetCustomer(id));
        }
        // GET: /Customer/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: /Customer/Create
        [HttpPost]
        public ActionResult Create(TDTDCustomer cus)
        {
            listCustomer.AddCustomer(cus);
            return RedirectToAction("GetCustomers");
        }
        // GET: /Customer/Edit/5
        public ActionResult Edit(string id)
        {
            return View(listCustomer.GetCustomer(id));
        }
        // POST: /Customer/Edit
        [HttpPost]
        public ActionResult Edit(TDTDCustomer cus)
        {
            listCustomer.UpdateCustomer(cus);
            return RedirectToAction("GetCustomers");
        }
        // GET: /Customer/Delete/5
        public ActionResult Delete(string id)
        {
            listCustomer.DeleteCustomer(listCustomer.GetCustomer(id));
            return RedirectToAction("GetCustomers");
        }
    }
}