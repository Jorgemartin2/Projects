using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using App.Data;
using App.Models;
using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;

namespace App.Pages.Tasks
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly App.Data.ApplicationDbContext _context;
        public CreateModel(App.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public TasksModel TasksModel { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                if (!ModelState.IsValid || _context.Tasks == null || TasksModel == null)
                {
                    return Page();
                }
                TasksModel.User = User.Identity.Name;
                _context.Tasks.Add(TasksModel);
                TempData["MessageSuccess"] = "Tarefa cadastrada com sucesso!";
                await _context.SaveChangesAsync();

                return RedirectToPage("./Index");
            }
            catch (System.Exception erro)
            {
                TempData["MessageErro"]=$"Ops, não conseguimos cadastrar sua tarefa, tente novamente! Detalhe do erro {erro.Message}";
                return RedirectToPage("./Index");
            }

        }
    }
}
