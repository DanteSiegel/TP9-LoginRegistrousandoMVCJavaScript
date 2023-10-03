using System.Collections.Generic;
using System;
using System.Data.SqlClient;
using Dapper;
namespace TP9-LoginRegistrousandoMVCJavaScript.Models;

public static class BD
{
    private static string ConnectionString = @"Server=localhost; DataBase=BaseDeDatos; Trusted_Connection=True";

    public static void Registro(string UserName,string Contrasena,string Nombre,string Email,int Telefono)
    {
        string sql = "INSERT INTO Usuario (UserName,Contrasena,Nombre,Email,Telefono) VALUES ("+UserName+", "+Contrasena+", "+Nombre+", "+Email+","+Telefono");";
        using(SqlConnection db = new SqlConnection(ConnectionString))
        {
            db.INSERT<Usuario>(sql);
        }
    }

        public static bool ValidarRegistro(string UserName)
    {
        string sql = "Select Count("UserName") from Usuario";
        using(SqlConnection db = new SqlConnection(ConnectionString))
        {
            int Count = db.Query<Usuario>(sql);
            Valido = Count = 0;
        }
        return Valido;
    }

        public static Usuario ValidarLogIn(string UserName,string Contrasena)
    {
         Usuario User = new Usuario();
        string sql = "Select * from Usuario where UserName = "+ UserName +" and Contrasena = " + Contrasena +";";
        
        using(SqlConnection db = new SqlConnection(ConnectionString))
        {
            User = db.Query<Usuario>(sql);
        }
        return User;

        //devuelve o un objeto del tipo usuario o null
    }

    }



