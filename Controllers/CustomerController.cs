using LoanManagementDone.Models;
using LoanManagementDone.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagementDone.Controllers
{
    public class CustomerController : Controller
    {

      
        LoanManagementSystemContext _context = new LoanManagementSystemContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LoanCreate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoanCreate(LoanApplication Loan)

        {
            if (!ModelState.IsValid) 
                return View(Loan);
          
            _context.LoanApplications.Add(Loan);
            
            _context.SaveChanges();
            return RedirectToAction("MyLoans");
        }
        public ActionResult MyLoans()
        {
            LoanApplicationViewModel loanApplicationViewModel = new LoanApplicationViewModel();
        
           
            var loanApplication = _context.LoanApplications.ToList();
            return View(loanApplication);
        }


    }
}
