using BudgetAppWeb.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetAppWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BudgetController : Controller
    {
        DataContext _context { get; set; }

        public BudgetController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetBudgetItems()
        {
            var budgetItems = await _context.BudgetItems.ToListAsync();
            return Ok(budgetItems);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetBudgetItem(int id)
        {
            var budgetItem = await _context.BudgetItems.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(budgetItem);
        }
    }
}
