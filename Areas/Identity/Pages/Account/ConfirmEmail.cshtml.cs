using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;

namespace login4.Areas.Identity.Pages.Account
{
    public class ConfirmEmailModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;

        public ConfirmEmailModel(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }
        [BindProperty]
        public InputModel Input { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public class InputModel
        {
            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            public string Token { get; set; }

            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "La contraseña y la contraseña de confirmación no coinciden.")]
            public string ConfirmPassword { get; set; }

            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            //[Required]
            //public string Code { get; set; }

        }
        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [TempData]
        public string StatusMessage { get; set; }
        public string mail;

        //a traves del link de confirmacion recibe la id de usuario y el token de confirmacionde email
        public async Task<IActionResult> OnGetAsync(string userId, string code)
        {
            try { 
            var user = await _userManager.FindByIdAsync(userId);
           
            if (userId == null || code == null)
            { 
                
                return RedirectToPage("/Index");
            }

           
          
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{userId}'.");
            }
            ViewData["mail"] = user.Email;
            ViewData["code"] = code;
                return Page();
            }catch (Exception ex)
            {
                return RedirectToPage("/Error");
            }
            
            }
        
        //al validar el formulario de cambio de contraseña, elimina la pass automatica para introducir la nueva passs 
        //entonces es cuando confirma el email
        public async Task<IActionResult> OnPostAsync()
        {
            try { 
            var user = await _userManager.FindByEmailAsync(Input.Email);
            var token = Input.Token;
            if (user == null)
            {
                // Don't reveal that the user does not exist
                return RedirectToPage("/GestionUsuarios/RegisterEx");
            }
            
            
                
                //var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var confirmacion = await _userManager.ConfirmEmailAsync(user, token);
                var result = await _userManager.RemovePasswordAsync(user);

                var resultado = await _userManager.AddPasswordAsync(user, Input.Password);
                return RedirectToPage("/GestionUsuarios/LoginEx");
            
            }
            catch (Exception ex) { 

            return RedirectToPage("/Error");
        }}
    }
}




