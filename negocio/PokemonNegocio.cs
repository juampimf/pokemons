﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
using negocio;
using System.Security.Cryptography.X509Certificates;

namespace negocio
{
    public class PokemonNegocio
    {
        public List<Pokemon> listar()
        {
            List<Pokemon> lista = new List<Pokemon>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad\r\nfrom POKEMONS P, ELEMENTOS E, ELEMENTOS D\r\nwhere E.Id = P.IdTipo\r\nand D.Id = P.IdDebilidad";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Numero = lector.GetInt32(0);
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];

                    //if (!(lector.IsDBNull(lector.GetOrdinal("UrlImagen")))) 
                    //aux.UrlImagen = (string)lector["UrlImagen"];
                    if (!(lector["UrlImagen"] is DBNull))
                        aux.UrlImagen = (string)lector["UrlImagen"];






                    aux.Tipo = new Elemento();
                    aux.Tipo.Descripcion = (string)lector["Tipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Descripcion = (string)lector["Debilidad"];
                    

                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }

           

        }
        public void agregar(Pokemon nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into POKEMONS (Numero,Nombre,Descripcion,Activo,idTipo,idDebilidad,UrlImagen) values (" + nuevo.Numero + ",'" + nuevo.Nombre + "','" + nuevo.Descripcion + "',1, @idTipo, @idDebilidad, @UrlImagen)");
                datos.setearParametro("@idTipo", nuevo.Tipo.Id);
                datos.setearParametro("@idDebilidad", nuevo.Debilidad.Id);
                datos.setearParametro("@UrlImagen", nuevo.UrlImagen);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}


