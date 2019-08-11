using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetAppWeb.Models
{
    public class BudgetItem
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }

    }
}
