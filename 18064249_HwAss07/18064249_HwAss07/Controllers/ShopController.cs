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
        [HttpPost]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddItem(string NameOfItem,string description,double price,int QuantityNumber)
        {
            List<ShowItemViewModel> newItem = new List<ShowItemViewModel>();
            ShowItemViewModel item = new ShowItemViewModel(NameOfItem, description, price, QuantityNumber);
            newItem.Add(item);
            return View();
        }
    }
}