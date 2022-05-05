using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final_Project.Pages
{
    public class ContactModel : PageModel
    {
        private readonly ILogger<ContactModel> _logger;
        
        [BindProperty]
        [Required]
        public string Name {get; set;}
        
        [BindProperty]
        [Display(Name = "E-Mail")]
        [Required]
        [EmailAddress]
        public string Email {get; set;}

        [BindProperty]
        [Required]
        [StringLength(200)]
        public string Message {get; set;}

        public ContactModel(ILogger<ContactModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            _logger.LogWarning($"{Name} ({Email}): {Message}");
        }
    }
}