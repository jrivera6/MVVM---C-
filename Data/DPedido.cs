﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Data
{
    public class DPedido
    {
        public List<Pedido> GetPedidos(Pedido pedido)
        {
            SqlParameter[] parameters = null;
            string comandText = string.Empty;
            List<Pedido> pedidos = null;

            try
            {
                comandText = "usp_fechafecha";
                parameters = new SqlParameter[2];
                parameters[0] = new SqlParameter("@fec1", System.Data.SqlDbType.DateTime);
                parameters[0].Value = pedido.FechaInicio;
                parameters[1] = new SqlParameter("@fec2", System.Data.SqlDbType.DateTime);
                parameters[1].Value = pedido.FechaFin;
                pedidos = new List<Pedido>();

                using (SqlDataReader reader = SQLHelper.ExecuteReader(SQLHelper.Connection, comandText,
                    CommandType.StoredProcedure, parameters))
                {
                    while (reader.Read())
                    {
                        pedidos.Add(new Pedido
                        {
                            IdPedido = reader["IdPedido"] != null ? Convert.ToInt32(reader["IdPedido"]) : 0,
                            IdCliente = reader["IdCliente"] != null ? Convert.ToString(reader["IdCliente"]) : string.Empty,
                            IdEmpleado = reader["IdEmpleado"] != null ? Convert.ToInt32(reader["IdEmpleado"]) : 0,
                            FechaPedido = reader["FechaPedido"] != DBNull.Value ? Convert.ToDateTime(reader["FechaPedido"]) : DateTime.MinValue,
                            FechaEntrega = reader["FechaEntrega"] != DBNull.Value ? Convert.ToDateTime(reader["FechaEntrega"]) : DateTime.MinValue,
                            FechaEnvio = reader["FechaEnvio"] != DBNull.Value ? Convert.ToDateTime(reader["FechaEnvio"]) : DateTime.MinValue,
                            FormaEnvio = reader["FormaEnvio"] != null ? Convert.ToInt32(reader["FormaEnvio"]) : 0,
                            Cargo = reader["Cargo"] != null ? Convert.ToInt32(reader["Cargo"]) : 0,
                            Destinatario = reader["Destinatario"] != null ? Convert.ToString(reader["Destinatario"]) : string.Empty,
                            DireccionDestinatario = reader["DireccionDestinatario"] != null ? Convert.ToString(reader["DireccionDestinatario"]) : string.Empty,
                            RegionDestinatario = reader["RegionDestinatario"] != null ? Convert.ToString(reader["RegionDestinatario"]) : string.Empty,
                            CodPostalDestinatario = reader["CodPostalDestinatario"] != null ? Convert.ToString(reader["CodPostalDestinatario"]) : string.Empty,
                            PaisDestinatario = reader["PaisDestinatario"] != null ? Convert.ToString(reader["PaisDestinatario"]) : string.Empty

                        });
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }


            return pedidos;
        }
    }
}
