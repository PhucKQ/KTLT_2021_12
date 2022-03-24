using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Demo_KTLT_2021_12.Pages
{
    public class MH_TestModel : PageModel
    {
        public string Chuoi { get; set; }
        public int A { get; set; }
        public int sum;

        [BindProperty]
        public int X { get; set; }
        [BindProperty]
        public int Y { get; set; }
        public void OnGet()
        {
            Chuoi = "Chao cac ban";
            A = 100;
        }

        public void OnPost()
        {
            sum = X + Y;
        }
    }
}
