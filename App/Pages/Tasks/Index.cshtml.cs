using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using App.Data;
using App.Models;
using Microsoft.AspNetCore.Authorization;

namespace App.Pages.Tasks
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly App.Data.ApplicationDbContext _context;

        public IndexModel(App.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<TasksModel> TasksModel { get; set; } = default!;

        public async Task OnGetAsync()
        {

            if (_context.Tasks != null)
            {
                TasksModel = await _context.Tasks
                .AsNoTracking()
                .Where(m=>m.User == User.Identity.Name)
                .ToListAsync();
            }
        }
    }
}
