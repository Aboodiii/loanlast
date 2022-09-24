using LoanManagementDone.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LoanManagementDone.Controllers
{
    public class AccountController : Controller

    {
        LoanManagementSystemContext _context = new LoanManagementSystemContext();
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        public ActionResult Verify(Admin Add, Customer cust)
        {
            return View();
        }
    }
}
