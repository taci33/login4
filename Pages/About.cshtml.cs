using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace login4.Pages 
{

    [Authorize]
    public class AboutModel : PageModel {
        public void OnGet() {

        }
    }
}
