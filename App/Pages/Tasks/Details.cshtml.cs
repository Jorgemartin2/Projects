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
    public class DetailsModel : PageModel
    {
        private readonly App.Data.ApplicationDbContext _context;

        public DetailsModel(App.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public TasksModel TasksModel { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Tasks == null)
            {
                return NotFound();
            }

            var tasksmodel = await _context.Tasks.FirstOrDefaultAsync(m => m.Id == id);
            if (tasksmodel == null || tasksmodel.User != User.Identity.Name)
            {
                return NotFound();
            }
            else
            {
                TasksModel = tasksmodel;
            }
            return Page();
        }
    }
}
