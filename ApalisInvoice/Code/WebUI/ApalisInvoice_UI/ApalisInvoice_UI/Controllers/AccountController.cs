using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ApalisInvoice_UI.Common;
using ApalisInvoice_UI.Interface;
using ApalisInvoice_UI.Interface.Common;
using ApalisInvoice_UI.Models;
using ApalisInvoice_UI.ViewModel;
using ApalisInvoiceViewModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApalisInvoice_UI.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly IUserService userService;

        public AccountController(IUserService userService)
        {
            this.userService = userService;
        }

        public IActionResult Login() => View();
        [HttpPost]
        public async Task<ActionResult> SignIn(LoginViewModel objLoginViewModel, string returnUrl = null)
        {
            if (!ModelState.IsValid) { return View("Login"); }

            var user = userService.UserByUserName(objLoginViewModel.UserName);

            if (user == null) { return RedirectToAction(nameof(Login)); }
            if (user.Password != Cryptography.Encrypt(objLoginViewModel.Password, "ApalisInvoice")) { return RedirectToAction(nameof(Login)); }

           // if (!user.IsAppAccess.HasValue) { return RedirectToAction(nameof(Login)); }

            // RoleModel _objRoleModel = _objUserService.GetRoleById(_objUserModel.RoleID);

            var _objIdentity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, objLoginViewModel.UserName),
                                                         new Claim(ClaimTypes.UserData, string.Format("{0}", Cryptography.Encrypt(user.UserId.ToString(), "ApalisInvoice"))),}, CookieAuthenticationDefaults.AuthenticationScheme);
            var _objPrincipal = new ClaimsPrincipal(_objIdentity);
            AuthenticationProperties _objAuthProp = new AuthenticationProperties();
            _objAuthProp.ExpiresUtc = DateTime.UtcNow.AddMinutes(30.0);
            _objAuthProp.AllowRefresh = true;
            _objAuthProp.IsPersistent = true;
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, _objPrincipal, _objAuthProp);
            if (Url.IsLocalUrl(returnUrl))
                return Redirect(returnUrl);
            else
                return Redirect("../Home/Dashboard");
        }
        public async Task<ActionResult> Signout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction(nameof(Login));
        }

    }
}