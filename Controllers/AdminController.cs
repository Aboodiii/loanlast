using LoanManagementDone.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace BootstrapTemplateIntegration.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        public string insertmessage;
        LoanManagementSystemContext _context = new LoanManagementSystemContext();
        // GET: Admin
        public ActionResult Index()
        {
            var customer = _context.Customers.ToList();
            return View(customer);
        }

        public ActionResult Details(int? id)
        {

            var detailsCustomer = _context.Customers.Find(id);

            return View(detailsCustomer);
        }

        public ActionResult LOanAppDetails(int? id)
        {

            var detailsLoan = _context.LoanApplications.Find(id);

            return View(detailsLoan);
        }

        public ActionResult SuretyDetails(long? Sid)
        {
            var detailssurety = _context.Customers.Where(temp => temp.SuretyId == Sid).FirstOrDefault();

            return View(detailssurety);
        }




        public ActionResult Create()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult Create(Customer custmr)

        {
            if (!ModelState.IsValid)
                return View(custmr);
            _context.Customers.Add(custmr);
            _context.SaveChanges();
            insertmessage = "New User Record Inserted Successfully";
            return RedirectToAction("Index");
        }

        public ActionResult SuretyCreate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SuretyCreate(Surety surety)

        {
            if (!ModelState.IsValid)
                return View(surety);
            _context.Sureties.Add(surety);          
            _context.SaveChanges();
            ViewBag.Suretyidd = surety.SuretyId;
            return RedirectToAction("Create");
        }

        public ActionResult Edit(int? id)
        {
            var exsitingCust = _context.Customers.Find(id);
            return View(exsitingCust);
        }



        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }





        public ActionResult Delete(int? id)
        {
            var exsitingCust = _context.Customers.Find(id);
            return View(exsitingCust);
        }
        [HttpPost]
        public ActionResult Delete(int? id, Customer customer)
        {
            var exsitingCust = _context.Customers.Find(id);
            _context.Customers.Remove(exsitingCust);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
