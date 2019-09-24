using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DDetallePedido
    {
        public List<DetallePedido> GetDetallePedidos(DetallePedido detallePedido)
        {
            SqlParameter[] parameters = null;
            string comandText = string.Empty;
            List<DetallePedido> detallePedidos = null;

            try
            {
                comandText = "usp_detailorder";
                parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("orderId", System.Data.SqlDbType.Int);
                parameters[0].Value = detallePedido.Pedido.IdPedido;
                detallePedidos = new List<DetallePedido>();

                using(SqlDataReader reader = SQLHelper.ExecuteReader(SQLHelper.Connection, comandText,
                    CommandType.StoredProcedure, parameters))
                {
                    while (reader.Read())
                    {
                        detallePedidos.Add(new DetallePedido
                        {
                            //IdPedido = reader["IdPedido"] != null ? Convert.ToInt32(reader["IdPedido"]) : 0,
                            IdProducto = reader["IdProducto"] != null ? Convert.ToInt32(reader["IdProducto"]) : 0,
                            PrecioUnidad = reader["PrecioUnidad"] != null ? Convert.ToDecimal(reader["PrecioUnidad"]) : 0,
                            Cantidad = reader["Cantidad"] != null ? Convert.ToInt32(reader["Cantidad"]) : 0,
                            Descuento = reader["Descuento"] != null ? Convert.ToDecimal(reader["Descuento"]) : 0


                        });
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return detallePedidos;
        } 
    }
}
