using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class LetsLearnRazorModel : PageModel
    {
        public int Number { get; private set; } = 12;
        public string CustomString { get; private set; } = "franta";

        public void OnGet()
        {
            this.Number += 123;
        }
    }
}
