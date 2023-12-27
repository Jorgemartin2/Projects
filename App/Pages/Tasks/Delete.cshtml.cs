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
    public class DeleteModel : PageModel
    {
        private readonly App.Data.ApplicationDbContext _context;

        public DeleteModel(App.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Tasks == null)
            {
                return NotFound();
            }
            var tasksmodel = await _context.Tasks.FindAsync(id);
            if (tasksmodel != null)
            {
                TasksModel = tasksmodel;
                _context.Tasks.Remove(TasksModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
