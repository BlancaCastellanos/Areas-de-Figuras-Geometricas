﻿using System;
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

namespace AreasdeFigurasGeometricas
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

        private void BtnRectangulo_Click(object sender, RoutedEventArgs e)
        {
            int numero1r =
                int.Parse(txtNumero1R.Text);
            int numero2r =
                int.Parse(txtNumero2R.Text);
            int resultado =
                numero1r * numero2r;
            lblResultadoR.Text = resultado.ToString();
        }

        private void BtnTriangulo_Click(object sender, RoutedEventArgs e)
        {
            int numero1t =
                int.Parse(txtNumero1T.Text);
            int numero2t =
                int.Parse(txtNumero2T.Text);
            int resultado =
                (numero1t * numero2t)/2;
            lblResultadoT.Text = resultado.ToString();
        }

        private void BtnCirculo_Click(object sender, RoutedEventArgs e)
        {
            double numeropi = 3.1416;

            double numero1c =
                double.Parse(txtNumero1C.Text);
            double resultado =
                (*numero1c)(3.1416*numero1c);
            lblResultadoC.Text = resultado.ToString();
        }

        private void BtnTrapecio_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
