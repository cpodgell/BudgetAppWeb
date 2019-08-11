using BudgetAppWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetAppWeb.Data
{
    public class DataContext : DbContext
    {
        public DbSet<BudgetItem> BudgetItems { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

    }
}
