using Loan.Data;
using Loan.Models.Entities;
using Loan.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Loan.Controllers
{
    public class LoanController : Controller
    {
        private readonly LoanContext context;

        public LoanController(LoanContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Loan()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Loan(LoanViewModel viewModel)
        {
            var loan = new LoanDetails
            {
                Amount = viewModel.Amount,
                Tenure = viewModel.Tenure,
            };
            context.loans.Add(loan);
            context.SaveChanges();
            return View("Loan");
        }
    }
}
