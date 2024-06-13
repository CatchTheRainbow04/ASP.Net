using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Lab_04._1.Models
{
    public class XmlHelper
    {
        public static List<Product> ReadXmlFile(string filePath)
        {
            var products = new List<Product>();

            XDocument doc = XDocument.Load(filePath);
            foreach (var element in doc.Descendants("Product"))
            {
                var product = new Product
                {
                    ProductId = element.Element("ProductId")?.Value,
                    ProductName = element.Element("ProductName")?.Value,
                    Unit = element.Element("Unit")?.Value,
                    Price = decimal.Parse(element.Element("Price")?.Value)
                };

                products.Add(product);
            }

            return products;
        }
        public static void UpdateProduct(string filePath, Product updatedProduct)
        {
            XDocument doc = XDocument.Load(filePath);
            var productElement = doc.Descendants("Product")
                                    .FirstOrDefault(p => p.Element("ProductId")?.Value == updatedProduct.ProductId);

            if (productElement != null)
            {
                productElement.Element("ProductName")?.SetValue(updatedProduct.ProductName);
                productElement.Element("Unit")?.SetValue(updatedProduct.Unit);
                productElement.Element("Price")?.SetValue(updatedProduct.Price);
                doc.Save(filePath);
            }
        }
        public static void DeleteProduct(string filePath, string productId)
        {
            XDocument doc = XDocument.Load(filePath);
            var productElement = doc.Descendants("Product")
                                    .FirstOrDefault(p => p.Element("ProductId")?.Value == productId);

            if (productElement != null)
            {
                productElement.Remove();
                doc.Save(filePath);
            }
        }
        public static List<Product> SearchProducts(string filePath, string searchTerm)
        {
            XDocument doc = XDocument.Load(filePath);
            var products = doc.Descendants("Product")
                              .Where(p => p.Element("ProductName")?.Value.Contains(searchTerm) == true)
                              .Select(p => new Product
                              {
                                  ProductId = p.Element("ProductId")?.Value,
                                  ProductName = p.Element("ProductName")?.Value,
                                  Unit = p.Element("Unit")?.Value,
                                  Price = decimal.Parse(p.Element("Price")?.Value)
                              }).ToList();

            return products;
        }
        public static void AddProduct(string filePath, Product newProduct)
        {
            XDocument doc = XDocument.Load(filePath);
            XElement newProductElement = new XElement("Product",
                new XElement("ProductId", newProduct.ProductId),
                new XElement("ProductName", newProduct.ProductName),
                new XElement("Unit", newProduct.Unit),
                new XElement("Price", newProduct.Price));

            doc.Element("Products").Add(newProductElement);
            doc.Save(filePath);
        }
    }
}