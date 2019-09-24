﻿using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BDetallePedido
    {
        private DDetallePedido DDetallePedido = null;

        public List<DetallePedido> GetDetallePedidosPorId(int IdPedido)
        {
            List<DetallePedido> DetallePedidos = null;
            try
            {
                DDetallePedido = new DDetallePedido();
                DetallePedidos = DDetallePedido.GetDetallePedidos(new DetallePedido { Pedido = new Pedido { IdPedido = IdPedido } });

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                DDetallePedido = null;
            }
            return DetallePedidos;
        }

        public decimal GetDetalleTotalPorId(int IdPedido)
        {
            List<DetallePedido> DetallePedidos = null;
            decimal total = 0;

            try
            {
                DDetallePedido = new DDetallePedido();
                DetallePedidos = DDetallePedido.GetDetallePedidos(new DetallePedido { Pedido = new Pedido { IdPedido = IdPedido } });

                foreach(var dp in DetallePedidos)
                {
                    total = total + dp.Cantidad * dp.PrecioUnidad - dp.Descuento;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                DDetallePedido = null;
            }
            return total;
        }
    }
}
