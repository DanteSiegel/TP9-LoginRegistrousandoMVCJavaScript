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
            db.Execute(sql, new{Username = usuario.UserName, contrasena = usuario.Contrasena ,nombre = usuario.Nombre, email = usuario.Email ,tel = usuario.Telefono});
        }
    }

        public static bool ValidarRegistro(string UserName)
    {

        string sql = "Select * from Usuario where UserName = "+UserName+"";
        bool Valido=false;
        using(SqlConnection db = new SqlConnection(ConnectionString))
        {
                
                int Count = db.Query<Usuario>(sql).AsEnumerable().Count();
                Valido = Count == 0;
        }
        return Valido;
    }

        public static Usuario ValidarLogIn(string UserName,string Contrasena)
    {
        Usuario User = null;
        string sql = "Select * from Usuario where UserName = @username and Contrasena = @contrasena;";
        using(SqlConnection db = new SqlConnection(ConnectionString))
        {
            User = db.QueryFirstOrDefault<Usuario>(sql, new {username = UserName, contrasena = Contrasena});
        }
        return User;

        //devuelve o un objeto del tipo usuario o null
    }

            public static Usuario ObtenerContraseña(string UserName)
    {

        string sql = "Select * from Usuario where UserName = "+UserName+" ";
        Usuario User = new Usuario();

        using(SqlConnection db = new SqlConnection(ConnectionString))
        {
                
            User = db.QueryFirst<Usuario>(sql);

        }
        return User;
    }

}



