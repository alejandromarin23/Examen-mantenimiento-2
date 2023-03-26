using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Datos
{
    public class TicketDB
    {
        string cadena_conexion = "server=localhost; user=root; database=ticket; password=Ale_Rodriguez23";

        public Usuario Autenticar(Login login)
        {
            Usuario user = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM usuarios WHERE CodigoUsuario=@CodigoUsuario  AND Contraseña= @Contraseña;");
              
                using (MySqlConnection _conexion = new MySqlConnection(cadena_conexion)) //_conexion: objeto conexion sql
                {
                    _conexion.Open(); //abiendo la conexion
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = login.CodigoUsuario;
                        comando.Parameters.Add("@Contraseña", MySqlDbType.VarChar, 80).Value = login.Contraseña;

                        MySqlDataReader dr = comando.ExecuteReader(); //para lectura de registros temporales de la db

                        if (dr.Read())
                        {
                            user = new Usuario();
                            user.CodigoUsuario = dr["CodigoUsuario"].ToString();
                            user.Contraseña = dr["Contraseña"].ToString();
                            
                        }
                    }
                }
               
            }
            catch (System.Exception ex)
            {

            }

            return user;


        }

        public bool Insertar(Ticket ticket)

        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO nuevoticket VALUES");
                sql.Append(" (@Usuario, @Cliente, @TipoSoporte, @DescripcionSolicitud, @DescripcionRespuesta, @Precio, @Impuesto, @Total, @Fecha); ");
                using (MySqlConnection _conexion = new MySqlConnection(cadena_conexion))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Usuario", MySqlDbType.VarChar, 50).Value = ticket.Usuario;
                        comando.Parameters.Add("@Cliente", MySqlDbType.VarChar, 45).Value = ticket.Cliente;
                        comando.Parameters.Add("@TipoSoporte", MySqlDbType.VarChar, 80).Value = ticket.TipoSoporte;
                        comando.Parameters.Add("@DescripcionSolicitud", MySqlDbType.VarChar, 200).Value = ticket.DescripcionSolicitud;
                        comando.Parameters.Add("@DescripcionRespuesta", MySqlDbType.VarChar, 200).Value = ticket.DescripcionRespuesta;
                        comando.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = ticket.Precio;
                        comando.Parameters.Add("@Impuesto", MySqlDbType.Decimal).Value = ticket.Impuesto;
                        comando.Parameters.Add("@Total", MySqlDbType.Decimal).Value = ticket.Total;
                        comando.Parameters.Add("@Fecha", MySqlDbType.DateTime).Value = DateTime.Now;            
                        comando.ExecuteNonQuery();
                        inserto = true;

                       
                    }
                }

            }
            catch (System.Exception ex)
            {
                Console.Out.WriteLine(ex.Message);
            }
            return inserto;

            
        }

       
        

        public DataTable DevolverUsuario()
        {
            DataTable dataTable = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM nuevoticket");
                using (MySqlConnection _conexion = new MySqlConnection(cadena_conexion))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        MySqlDataReader dr = comando.ExecuteReader();

                 
                        dataTable.Load(dr);

                    }
                }

            }
            catch (Exception ex)
            {

            }
            return dataTable;
            
        }
    }

       
    
}

