using System;
using System.Collections.Generic;
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

namespace Proyecto2doParcial
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

        private void CbLista_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            switch (cbLista.SelectedIndex)
            {
                case 0:
                    GrdInterfaz.Children.Add(new Camiseta());
                    break;
                case 1:
                    GrdInterfaz.Children.Add(new Pantalon());
                    break;
                case 2:
                    GrdInterfaz.Children.Add(new Falda());
                    break;
                case 3:
                    GrdInterfaz.Children.Add(new Zapatos());
                    break;
                case 4:
                    GrdInterfaz.Children.Add(new RopaInterior());
                    break;
                case 5:
                    GrdInterfaz.Children.Add(new Gorras());
                    break;
            }
            GrdInterfaz.Visibility = Visibility.Visible;
            btnCancelar.Visibility = Visibility.Visible;
            btnGuardar.Visibility = Visibility.Visible;
            lblForzado.Visibility = Visibility.Hidden;
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            switch(cbLista.SelectedIndex)
            {
                case 0:
                       if(string.IsNullOrEmpty(((Camiseta)(GrdInterfaz.Children[0])).txtCodigoCamiseta.Text) ||
                        string.IsNullOrEmpty(((Camiseta)(GrdInterfaz.Children[0])).txtDescripcionCamiseta.Text) ||
                        string.IsNullOrEmpty(((Camiseta)(GrdInterfaz.Children[0])).txtPrecioCamiseta.Text) ||
                        string.IsNullOrEmpty(((Camiseta)(GrdInterfaz.Children[0])).txtDescuentoCamiseta.Text) ||
                        string.IsNullOrEmpty(((Camiseta)(GrdInterfaz.Children[0])).txtProveedorCamiseta.Text) ||
                        (((Camiseta)(GrdInterfaz.Children[0])).rbFormalCamiseta.IsChecked == false && ((Camiseta)(GrdInterfaz.Children[0])).rbInformalCamiseta.IsChecked == false) ||
                        (((Camiseta)(GrdInterfaz.Children[0])).ckbCueroCamiseta.IsChecked == false && ((Camiseta)(GrdInterfaz.Children[0])).ckbTelaCamiseta.IsChecked == false) ||
                        ((Camiseta)(GrdInterfaz.Children[0])).cbMarcaCamiseta.SelectedIndex == -1 ||
                        ((Camiseta)(GrdInterfaz.Children[0])).cbTallaCamiseta.SelectedIndex == -1)
                       {
                        lblForzado.Visibility = Visibility.Visible;
                       }
                       else
                       {
                        lblForzado.Visibility = Visibility.Hidden;
                        GrdInterfaz.Visibility = Visibility.Hidden;
                        btnCancelar.Visibility = Visibility.Hidden;
                        btnGuardar.Visibility = Visibility.Hidden;
                       }
                    break;

                case 1:
                    if (string.IsNullOrEmpty(((Pantalon)(GrdInterfaz.Children[0])).txtCodigoPantalon.Text) ||
                     string.IsNullOrEmpty(((Pantalon)(GrdInterfaz.Children[0])).txtDescripcionPantalon.Text) ||
                     string.IsNullOrEmpty(((Pantalon)(GrdInterfaz.Children[0])).txtPrecioPantalon.Text) ||
                     string.IsNullOrEmpty(((Pantalon)(GrdInterfaz.Children[0])).txtDescuentoPantalon.Text) ||
                     string.IsNullOrEmpty(((Pantalon)(GrdInterfaz.Children[0])).txtProveedorPantalon.Text) ||
                     (((Pantalon)(GrdInterfaz.Children[0])).rbFormalPantalon.IsChecked == false && ((Pantalon)(GrdInterfaz.Children[0])).rbInformalPantalon.IsChecked == false) ||
                     (((Pantalon)(GrdInterfaz.Children[0])).ckbCueroPantalon.IsChecked == false && ((Pantalon)(GrdInterfaz.Children[0])).ckbTelaPantalon.IsChecked == false) ||
                     ((Pantalon)(GrdInterfaz.Children[0])).cbMarcaPantalon.SelectedIndex == -1 ||
                     ((Pantalon)(GrdInterfaz.Children[0])).cbTallaPantalon.SelectedIndex == -1)
                    {
                        lblForzado.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        lblForzado.Visibility = Visibility.Hidden;
                        GrdInterfaz.Visibility = Visibility.Hidden;
                        btnCancelar.Visibility = Visibility.Hidden;
                        btnGuardar.Visibility = Visibility.Hidden;
                    }
                    break;

                case 2:
                    if (string.IsNullOrEmpty(((Falda)(GrdInterfaz.Children[0])).txtCodigoFalda.Text) ||
                     string.IsNullOrEmpty(((Falda)(GrdInterfaz.Children[0])).txtDescripcionFalda.Text) ||
                     string.IsNullOrEmpty(((Falda)(GrdInterfaz.Children[0])).txtPrecioFalda.Text) ||
                     string.IsNullOrEmpty(((Falda)(GrdInterfaz.Children[0])).txtDescuentoFalda.Text) ||
                     string.IsNullOrEmpty(((Falda)(GrdInterfaz.Children[0])).txtProveedorFalda.Text) ||
                     (((Falda)(GrdInterfaz.Children[0])).rbFormalFalda.IsChecked == false && ((Falda)(GrdInterfaz.Children[0])).rbInformalFalda.IsChecked == false) ||
                     (((Falda)(GrdInterfaz.Children[0])).ckbCueroFalda.IsChecked == false && ((Falda)(GrdInterfaz.Children[0])).ckbTelaFalda.IsChecked == false) ||
                     ((Falda)(GrdInterfaz.Children[0])).cbMarcaFalda.SelectedIndex == -1 ||
                     ((Falda)(GrdInterfaz.Children[0])).cbTallaFalda.SelectedIndex == -1)
                    {
                        lblForzado.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        lblForzado.Visibility = Visibility.Hidden;
                        GrdInterfaz.Visibility = Visibility.Hidden;
                        btnCancelar.Visibility = Visibility.Hidden;
                        btnGuardar.Visibility = Visibility.Hidden;
                    }
                    break;

                case 3:
                    if (string.IsNullOrEmpty(((Zapatos)(GrdInterfaz.Children[0])).txtCodigoZapatos.Text) ||
                     string.IsNullOrEmpty(((Zapatos)(GrdInterfaz.Children[0])).txtDescripcionZapatos.Text) ||
                     string.IsNullOrEmpty(((Zapatos)(GrdInterfaz.Children[0])).txtPrecioZapatos.Text) ||
                     string.IsNullOrEmpty(((Zapatos)(GrdInterfaz.Children[0])).txtDescuentoZapatos.Text) ||
                     string.IsNullOrEmpty(((Zapatos)(GrdInterfaz.Children[0])).txtProveedorZapatos.Text) ||
                     (((Zapatos)(GrdInterfaz.Children[0])).rbFormalZapatos.IsChecked == false && ((Zapatos)(GrdInterfaz.Children[0])).rbInformalZapatos.IsChecked == false) ||
                     (((Zapatos)(GrdInterfaz.Children[0])).ckbCueroZapatos.IsChecked == false && ((Zapatos)(GrdInterfaz.Children[0])).ckbTelaZapatos.IsChecked == false) ||
                     ((Zapatos)(GrdInterfaz.Children[0])).cbMarcaZapatos.SelectedIndex == -1 ||
                     ((Zapatos)(GrdInterfaz.Children[0])).cbTallaZapatos.SelectedIndex == -1)
                    {
                        lblForzado.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        lblForzado.Visibility = Visibility.Hidden;
                        GrdInterfaz.Visibility = Visibility.Hidden;
                        btnCancelar.Visibility = Visibility.Hidden;
                        btnGuardar.Visibility = Visibility.Hidden;
                    }
                    break;

                case 4:
                    if (string.IsNullOrEmpty(((RopaInterior)(GrdInterfaz.Children[0])).txtCodigoRopaInterior.Text) ||
                     string.IsNullOrEmpty(((RopaInterior)(GrdInterfaz.Children[0])).txtDescripcionRopaInterior.Text) ||
                     string.IsNullOrEmpty(((RopaInterior)(GrdInterfaz.Children[0])).txtPrecioRopaInterior.Text) ||
                     string.IsNullOrEmpty(((RopaInterior)(GrdInterfaz.Children[0])).txtDescuentoRopaInterior.Text) ||
                     string.IsNullOrEmpty(((RopaInterior)(GrdInterfaz.Children[0])).txtProveedorRopaInterior.Text) ||
                     (((RopaInterior)(GrdInterfaz.Children[0])).rbFormalRopaInterior.IsChecked == false && ((RopaInterior)(GrdInterfaz.Children[0])).rbInformalRopaInterior.IsChecked == false) ||
                     (((RopaInterior)(GrdInterfaz.Children[0])).ckbCueroRopaInterior.IsChecked == false && ((RopaInterior)(GrdInterfaz.Children[0])).ckbTelaRopaInterior.IsChecked == false) ||
                     ((RopaInterior)(GrdInterfaz.Children[0])).cbMarcaRopaInterior.SelectedIndex == -1 ||
                     ((RopaInterior)(GrdInterfaz.Children[0])).cbTallaRopaInterior.SelectedIndex == -1)
                    {
                        lblForzado.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        lblForzado.Visibility = Visibility.Hidden;
                        GrdInterfaz.Visibility = Visibility.Hidden;
                        btnCancelar.Visibility = Visibility.Hidden;
                        btnGuardar.Visibility = Visibility.Hidden;
                    }
                    break;

                case 5:
                    if (string.IsNullOrEmpty(((Gorras)(GrdInterfaz.Children[0])).txtCodigoGorras.Text) ||
                     string.IsNullOrEmpty(((Gorras)(GrdInterfaz.Children[0])).txtDescripcionGorras.Text) ||
                     string.IsNullOrEmpty(((Gorras)(GrdInterfaz.Children[0])).txtPrecioGorras.Text) ||
                     string.IsNullOrEmpty(((Gorras)(GrdInterfaz.Children[0])).txtDescuentoGorras.Text) ||
                     string.IsNullOrEmpty(((Gorras)(GrdInterfaz.Children[0])).txtProveedorGorras.Text) ||
                     (((Gorras)(GrdInterfaz.Children[0])).rbFormalGorras.IsChecked == false && ((Gorras)(GrdInterfaz.Children[0])).rbInformalGorras.IsChecked == false) ||
                     (((Gorras)(GrdInterfaz.Children[0])).ckbCueroGorras.IsChecked == false && ((Gorras)(GrdInterfaz.Children[0])).ckbTelaGorras.IsChecked == false) ||
                     ((Gorras)(GrdInterfaz.Children[0])).cbMarcaGorras.SelectedIndex == -1 ||
                     ((Gorras)(GrdInterfaz.Children[0])).cbTallaGorras.SelectedIndex == -1)
                    {
                        lblForzado.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        lblForzado.Visibility = Visibility.Hidden;
                        GrdInterfaz.Visibility = Visibility.Hidden;
                        btnCancelar.Visibility = Visibility.Hidden;
                        btnGuardar.Visibility = Visibility.Hidden;
                    }
                    break;

            }
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            GrdInterfaz.Children.Clear();
            btnCancelar.Visibility = Visibility.Hidden;
            btnGuardar.Visibility = Visibility.Hidden;
            lblForzado.Visibility = Visibility.Hidden;
        }
    }
}
