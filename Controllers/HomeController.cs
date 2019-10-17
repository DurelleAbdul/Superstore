using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Google.Authenticator;
using Superstore.ViewModels;

namespace Superstore.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        private const string key = "ctg321!@@)(";
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Welcome to the visualization of the Superstore dataset";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Email: Durelle.abdul.07@gmail.com\nContact number: 0817834771";

            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel login)
        {
            string message = "";
            bool status = false;

            if (login.username == "DurelleAbdul" && login.password == "26661543")
            {
                status = true;
                message = "2FA Verification";
                Session["Username"] = login.username;

                TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
                string userUniqueKey = login.username + key;
                Session["UserUniqueKey"] = userUniqueKey;
                var setupinfo = tfa.GenerateSetupCode("Superstore validation", login.username, userUniqueKey, 300, 300);
                ViewBag.BarcodeImageUrl = setupinfo.QrCodeSetupImageUrl;
                ViewBag.SetupCode = setupinfo.ManualEntryKey;
            }
            else
            {
                message = "Invalid credential";
            }
            ViewBag.Message = message;
            ViewBag.Status = status;
            return View();
        }

        public ActionResult myProfile()
        {
            if (Session["username"] == null || Session["IsValid2FA"] == null || !(bool)Session["IsValid2FA"])
            {
                return RedirectToAction("Login");
            }
            ViewBag.Message = "Welcome" + Session["username"].ToString();
            return View();
        }
        public ActionResult Verify2FA()
        {
            var token = Request["passcode"];
            TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
            string userUniqueKey = Session["UserUniqueKey"].ToString();
            bool isValid = tfa.ValidateTwoFactorPIN(userUniqueKey, token);
            if (isValid)
            {
                Session["IsValid2FA"] = true;
                return RedirectToAction("myProfile", "Home");
            }
            return RedirectToAction("Login", "Home");
        }
    }
}