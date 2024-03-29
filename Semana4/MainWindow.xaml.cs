﻿using Business;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Semana4
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void BtnConsultar_Click(object sender, RoutedEventArgs e)
        {
            BPedido bPedido = null;
            try
            {
                bPedido = new BPedido();
                dgvPedido.ItemsSource = bPedido.GetPedidosEntreFechas(Convert.ToDateTime(txtFechaInicio.Text),
                    Convert.ToDateTime(txtFechaFin.Text));

            }
            catch (Exception )
            {
                MessageBox.Show("Comunicarse con el Administrador");

            }
            finally
            {
                bPedido = null;
            }
        }


        private void DgvPedido_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BDetallePedido bDetalle = null;
            int idPedido;

            try
            {

                var item = dgvPedido.SelectedValue as Pedido;
                if (item == null) return;
                idPedido = Convert.ToInt32(item.IdPedido);


                bDetalle = new BDetallePedido();
                
                dgvDetallePedido.ItemsSource = bDetalle.GetDetallePedidosPorId(idPedido);
                dgvDetallePedido.Columns[0].Visibility = Visibility.Hidden;

                txtTotal.Text = "S/. "+Convert.ToString(bDetalle.GetDetalleTotalPorId(idPedido));
            }
            catch (Exception)
            {
                MessageBox.Show("Error 2");
            }
            finally
            {
                bDetalle = null;
            }
        }
    }
}
