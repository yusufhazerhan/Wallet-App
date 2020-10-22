using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using WalletApp.Models;

namespace WalletApp.Controllers
{
    public class TransactionsController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.transactions.ToList(); //List all transaction in Index Page
            return View(degerler);
        }
        [HttpGet]
        public IActionResult NewTransaction()
        {
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult NewTransaction(Transaction t)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            //Transaction adding process
            c.transactions.Add(t);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteTransaction(int id)
        {
            var transaction = c.transactions.Find(id); //finding id in database
            c.transactions.Remove(transaction); // Delete selected row
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DetailTransaction(int id)
        {
            var transaction = c.transactions.Find(id);
            return View("DetailTransaction", transaction); //it returns all information about the transaction
        }
        [ValidateAntiForgeryToken]
        public IActionResult UpdateTransaction(Transaction t)
        {
            if (!ModelState.IsValid)
            {
                var transaction = c.transactions.Find(t.Id); //if validation failed. Returns same page
                return View("DetailTransaction", transaction);
            }
            //Updating process
            c.transactions.Update(t);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult CultureManagement(string culture, string returnUrl) //Localization
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.Now.AddDays(30) });
            return LocalRedirect(returnUrl);
        }
    }
}