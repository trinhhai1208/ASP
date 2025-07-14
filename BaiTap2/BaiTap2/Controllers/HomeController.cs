using BaiTap2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap2.Controllers
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

        public ActionResult MyLink()
        {
            ViewBag.Message = "Liên kết của tôi.";
            return View();
        }

        public ActionResult ProductList()
        {
            //Khai báo biến danh sách mặt hàng
            List<Product> products = new List<Product>();
            //Tạo một danh sách 5 mặt hàng
            Product p1 = new Product(1, "Lạc", 40, 11);
            products.Add(p1);
            Product p2 = new Product(2, "Vừng", 5, 32);
            products.Add(p2);
            Product p3 = new Product(3, "Đỗ đen", 20, 21);
            products.Add(p3);
            Product p4 = new Product(4, "Đỗ xanh", 3, 15);
            products.Add(p4);
            Product p5 = new Product(5, "Đỗ đỏ", 4, 16);
            products.Add(p5);
            return View(products);
        }

    }
}