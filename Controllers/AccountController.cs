using LoginWithID.Database;
using LoginWithID.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LoginWithID.Controllers
{
    public class AccountController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;

        private readonly SignInManager<ApplicationUser> _signInManager;
        public AccountController(
         UserManager<ApplicationUser> userManager,
          SignInManager<ApplicationUser> signInManager

        )
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser {Name = model.Name,  UserName = model.Email, Email = model.Email, AddressLine1 = model.AddressLine1, AddressLine2 = model.AddressLine2, City = model.City, State = model.State, ContactNumber = model.ContactNumber, IsActive = true, Zipcode= model.Zipcode,PhoneNumber = model.Zipcode };
                var result = await _userManager.CreateAsync(user, model.Password);

            }



          return View(model);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {

            var result = await _signInManager.PasswordSignInAsync(loginViewModel.Email, loginViewModel.Password, loginViewModel.RememberMe, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            


          return View(loginViewModel);
        }




    }
}
