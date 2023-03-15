using Microsoft.AspNetCore.Mvc;
using Mission09_alexm99.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_alexm99.Conponents
{
    public class PurchaseSummaryViewComponent : ViewComponent
    {
        private Purchase purchase;
        public PurchaseSummaryViewComponent(Purchase purchaseService)
        {
            purchase = purchaseService;
        }
        public IViewComponentResult Invoke()
        {
            return View(purchase);
        }
    }
}
