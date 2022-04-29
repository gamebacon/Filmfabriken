using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using FilmFabriken.Model;
using FilmFabriken.Model.User;
using FilmFabriken.wwwroot.cs;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Logging;

namespace FilmFabriken.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        //private readonly IEmailSender _emailSender;
        
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _dbContext;

        public RegisterModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            //IEmailSender emailSender,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext dbContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            //_emailSender = emailSender;
            _roleManager = roleManager;
            _dbContext = dbContext;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {

            [Required(ErrorMessage = "Obligatoriskt fält")]
            [Display(Name = "Förnamn *")]
            public string FirstName { get; set; }
            
            [Display(Name = "Efternamn *")]
            [Required(ErrorMessage = "Obligatoriskt fält")]
            public string LastName { get; set; }

            [Required(ErrorMessage = "Obligatoriskt fält")]
            [Display(Name = "Användarnamn *")]
            public string UserName { get; set; }
            
            [EmailAddress]
            [Required(ErrorMessage = "Obligatoriskt fält")]
            [DataType(DataType.EmailAddress)]
            [Display(Name = "Email *")]
            public string Email { get; set; }
            
            [Display(Name = "Kön *")]
            public Gender Gender { get; set; }
            
            [Required(ErrorMessage = "Obligatoriskt fält")]
            [DataType(DataType.Password)]
            [Display(Name = "Lösenord *")]
            public string Password { get; set; }
            
            [DataType(DataType.Password)]
            [Required(ErrorMessage = "Obligatoriskt fält")]
            [Display(Name = "Upprepa lösenord *")]
            [Compare("Password", ErrorMessage = "Lösenorden matchar inte")]
            public string ConfirmPassword { get; set; }


            [Required(ErrorMessage = "Obligatoriskt fält")]
            [Display(Name = "Ögenfärg *")]
            public ConsoleColor eyeColor { get; set; }

            [Display(Name = "Admin")]
            public bool IsAdmin { get; set; }
            
            public override string ToString()
            {
                return $"username: {UserName}\n" +
                       $"password: {Password}\n" +
                       $"firstname: {FirstName}\n" +
                       $"lastname: {LastName}\n" +
                       $"gender: {Gender}\n" +
                       $"email: {Email}\n";
            }
        }
        /*
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }
        */

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                IdentityUser user = new User
                {
                    FirstName = Input.FirstName,
                    LastName = Input.LastName,
                    Gender = Input.Gender,
                    UserName = Input.UserName,
                    Email = Input.Email,
                };
                
                var result = await _userManager.CreateAsync(user, Input.Password);
                
                if (result.Succeeded)
                {

                    foreach (Util.Role role in Enum.GetValues(typeof(Util.Role)))
                    {
                        if (!await _roleManager.RoleExistsAsync(role.ToString()))
                            await _roleManager.CreateAsync(new IdentityRole(role.ToString()));
                    }
                    
                    await _userManager.AddToRoleAsync(user,
                        Input.IsAdmin ? Util.Role.Admin.ToString() : Util.Role.Default.ToString()
                        );
                    
                    _logger.LogInformation("User created a new account with password.");

                    /*
                        var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                        code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                        var callbackUrl = Url.Page(
                            "/Account/ConfirmEmail",
                            pageHandler: null,
                            values: new {area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl},
                            protocol: Request.Scheme);

                        await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                            $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");
                    */

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                
                foreach (IdentityError error in result.Errors)
                {
                    string errorMsg = "";

                    if (error.Code.Equals("DuplicateUserName"))
                        errorMsg = "Användarnamnet är upptaget.";
                    if (error.Code.Equals("DuplicateEmail"))
                        errorMsg = "Denna e-post är upptagen.";
                    if (error.Code.Equals("PasswordTooShort"))
                        errorMsg = "Lösenordet är för kort.";
                    
                    //Console.WriteLine($">{error.Code}< >{error.Description}<");
                    
                    ModelState.AddModelError(string.Empty, errorMsg);
                }
                
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
