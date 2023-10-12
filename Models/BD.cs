using System.Collections.Generic;
using System;
using System.Data.SqlClient;
using Dapper;
namespace TP9_LoginRegistrousandoMVCJavaScript.Models;

public static class BD
{
    private static string ConnectionString = @"Server=DESKTOP-E3OHN6P\SQLEXPRESS01; DataBase=BaseDeDatos; Trusted_Connection=True";

    public static void Registro(Usuario usuario)
    {
        string sql = "INSERT INTO Usuario (UserName,Contrasena,Nombre,Email,Telefono) VALUES (@username, @contrasena, @nombre, @email, @tel)";
        using(SqlConnection db = new SqlConnection(ConnectionString))
        {
            db.Execute(sql, new{username = usuario.UserName, contrasena = usuario.Contrasena ,nombre = usuario.Nombre, email = usuario.Email ,tel = usuario.Telefono});
        }
    }

        public static bool ValidarRegistro(Usuario usuario)
    {

        string sql = "Select * from Usuario where UserName = @username or Email = @email or Telefono = @telefono";
        bool Valido=false;
        using(SqlConnection db = new SqlConnection(ConnectionString))
        {
                
                int Count = db.Query<Usuario>(sql,new{username = usuario.UserName, email = usuario.Email, telefono = usuario.Telefono}).AsEnumerable().Count();
                Valido = Count == 0;
        }
        return Valido;
    }

        public static Usuario ValidarLogIn(string UserName,string Contrasena)
    {
        Usuario User = new Usuario();
        string sql = "Select * from Usuario where UserName = @pusername and Contrasena = @pcontrasena;";
        using(SqlConnection db = new SqlConnection(ConnectionString))
        {
            User = db.QueryFirstOrDefault<Usuario>(sql, new {pusername = UserName, pcontrasena = Contrasena});
        }
        return User;
    }

            public static Usuario ObtenerContraseña(Usuario usuario)
    {
        string sql = "Select * from Usuario where UserName = @pusername and Telefono = @ptelefono";
        Usuario User = new Usuario();
        using(SqlConnection db = new SqlConnection(ConnectionString))
        {        
            User = db.QueryFirstOrDefault<Usuario>(sql, new{pusername = usuario.UserName,ptelefono = usuario.Telefono});
        }
        return User;
    }

}



