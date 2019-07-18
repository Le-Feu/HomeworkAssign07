using _18064249_HwAss07.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _18064249_HwAss07.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddItem(string NameOfItem,string description,double price,int QuantityNumber)
        {
            List<ShowItemViewModel> newItem = new List<ShowItemViewModel>();
            ShowItemViewModel item = new ShowItemViewModel(NameOfItem, description, price, QuantityNumber);
            newItem.Add(item);
            return View(newItem);
        }
        public ActionResult testData()
        {
            List<ShowItemViewModel> test = new List<ShowItemViewModel>();
            ShowItemViewModel test1 = new ShowItemViewModel("Xanax", "Used for short term management of anxiety disorders, specifically panick disorder or generslized anxiety disorder", 56.00, 100);
            test.Add(test1);
            return View(test);
        }
    }
}