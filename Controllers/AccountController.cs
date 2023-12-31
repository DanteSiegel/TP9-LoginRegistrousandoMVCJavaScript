﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP9_LoginRegistrousandoMVCJavaScript.Models;

namespace TP9.Controllers;

public class Account : Controller
{
    public IActionResult Index()
    {
        ViewBag.aux = "Index";
        return View();
    }
    public IActionResult IniciarSesion()
    {
        ViewBag.aux = "IniciarSesion";
        return View();
    }
    public IActionResult Registrarse()
    {
        ViewBag.aux = "IniciarSesion";
        return View("Registrarse");
    }

    public IActionResult OlvidarContra()
    {
        return View("OlvideContrasena");
    }
    
    [HttpPost]
    public IActionResult Login(string UserName, string Password)
    {
        Usuario user = BD.ValidarLogIn(UserName, Password);
        if (user != null)
        {
            ViewBag.Error = "";
            ViewBag.aux = "Index";       
            return View("Index");
        }
        else
        {
            ViewBag.aux = "IniciarSesion";
            ViewBag.Error = "Usuario o contraseña incorrecta";
            return View("IniciarSesion");
        }
    }

    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        ViewBag.aux = "IniciarSesion";
        return RedirectToAction("IniciarSesion");
    }
    
    [HttpPost]
    public IActionResult Register(Usuario usuario)
    {

        if (BD.ValidarRegistro(usuario) == false)
        {
            ViewBag.Error = "La cuenta ya existe";
            return View("Registrarse");
        }
        else
        {
            ViewBag.aux = "IniciarSesion";
            BD.Registro(usuario);
            return RedirectToAction("IniciarSesion");
        }

        
    }
    
    [HttpPost]
    public IActionResult ForgotPassword(Usuario usuario)
    {
        Usuario user = BD.ObtenerContraseña(usuario);

        if (user != null)
        {
            ViewBag.aux = "Index";
            ViewBag.Contrasena = usuario.Contrasena;
            return View("OlvideContrasena");
        }
        else
        {
            ViewBag.aux = "IniciarSesion";
            ViewBag.Contrasena = "";
            ViewBag.Error = "El nombre de usuario no está registrado.";
            return View("OlvideContrasena");
        }
    }
}

