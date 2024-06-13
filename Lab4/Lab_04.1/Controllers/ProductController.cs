using Lab_04._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_04._1.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult ProductList(string searchTerm)
        {
            string filePath = Server.MapPath("~/App_Data/products.xml");
            var products = string.IsNullOrEmpty(searchTerm)
                ? XmlHelper.ReadXmlFile(filePath)
                : XmlHelper.SearchProducts(filePath, searchTerm);

            return View(products);
        }
        public ActionResult ProductDetail(string id)
        {
            string filePath = Server.MapPath("~/App_Data/products.xml");
            var products = XmlHelper.ReadXmlFile(filePath);
            var product = products.FirstOrDefault(p => p.ProductId == id);

            if (product == null)
            {
                return HttpNotFound();
            }

            return View(product);
        }
        public ActionResult ProductEdit(string id)
        {
            string filePath = Server.MapPath("~/App_Data/products.xml");
            var products = XmlHelper.ReadXmlFile(filePath);
            var product = products.FirstOrDefault(p => p.ProductId == id);

            if (product == null)
            {
                return HttpNotFound();
            }

            return View(product);
        }

        [HttpPost]
        public ActionResult ProductEdit(Product updatedProduct)
        {
            string filePath = Server.MapPath("~/App_Data/products.xml");
            XmlHelper.UpdateProduct(filePath, updatedProduct);

            return RedirectToAction("ProductList");
        }

        public ActionResult ProductDelete(string id)
        {
            string filePath = Server.MapPath("~/App_Data/products.xml");
            XmlHelper.DeleteProduct(filePath, id);
            return RedirectToAction("ProductList");
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProductCreate(Product newProduct)
        {
            if (ModelState.IsValid)
            {
                string filePath = Server.MapPath("~/App_Data/products.xml");
                XmlHelper.AddProduct(filePath, newProduct);
                return RedirectToAction("ProductList");
            }

            return View(newProduct);
        }
    }
}