using System;
using System.ComponentModel.DataAnnotations;
namespace TP9-LoginRegistrousandoMVCJavaScript.Models;

public static class Usuario
{
    public static string UserName{get;set;};
    private static string Contrasena{get;set;};
    private static string Nombre{get;set;};
    private static string Email{get;set;};
    private static int Telefono{get;set;};
    private static int idUsuario{get;set;};
}