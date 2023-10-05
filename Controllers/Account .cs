using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP9_LoginRegistrousandoMVCJavaScript.Models;

namespace TP9.Controllers;

public class HomeController : Controller
{
         public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

                public IActionResult Registro()
        {
            return View();
        }

                public IActionResult IniciarSesion()
        {
            return View();
        }

                        public IActionResult OlvideContraseña()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string UserName, string Password)
        {
            Usuario user = BD.ValidarLogIn(UserName, Password);

            if (user != null)
            {
                HttpContext.Session.SetInt32("UserId", user.idUsuario);
                return RedirectToAction("Home");
            }
            else
            {
                return View("Index", new { Error = "El usuario o la contraseña son incorrectos." });
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
    [HttpPost]
            public IActionResult Register(Usuario usuario)
        {

            if (!BD.ValidarRegistro(usuario.UserName))
            {
                return View("Registro", new { Error = "El nombre de usuario ya está en uso." });
            }

            BD.Registro(usuario);
            return RedirectToAction("IniciarSesion");
        }
    
    [HttpPost]
        public IActionResult ForgotPassword(string UserName)
        {
            Usuario user = BD.ObtenerContraseña(UserName);

            if (user != null)
            {
                ViewBag.Contraseña = user.Contrasena;
                return RedirectToAction("Index");
            }
            else
            {
                return View("ForgotPassword", new { Error = "El nombre de usuario no está registrado." });
            }
        }
}
