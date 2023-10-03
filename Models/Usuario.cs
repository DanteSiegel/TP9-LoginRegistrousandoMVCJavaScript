using System;
using System.ComponentModel.DataAnnotations;
namespace TP9_LoginRegistrousandoMVCJavaScript.Models;

public class Usuario
{
    public string UserName{get;set;}
    public string Contrasena{get;set;}
    public string Nombre{get;set;}
    public string Email{get;set;}
    public int Telefono{get;set;}
    public int idUsuario{get;set;}
}