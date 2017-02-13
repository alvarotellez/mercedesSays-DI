using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace simonSays_DI
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        private void comboNivel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (op1.IsSelected)
            {
                rec36.Fill = new SolidColorBrush(Colors.LightGray);
                rec35.Fill = new SolidColorBrush(Colors.LightGray);
                rec34.Fill = new SolidColorBrush(Colors.LightGray);
                rec33.Fill = new SolidColorBrush(Colors.LightGray);
                rec32.Fill = new SolidColorBrush(Colors.LightGray);
                rec31.Fill = new SolidColorBrush(Colors.LightGray);
                rec17.Fill = new SolidColorBrush(Colors.LightGray);
                rec30.Fill = new SolidColorBrush(Colors.LightGray);
                rec18.Fill = new SolidColorBrush(Colors.LightGray);
                rec29.Fill = new SolidColorBrush(Colors.LightGray);
                rec19.Fill = new SolidColorBrush(Colors.LightGray);
                rec28.Fill = new SolidColorBrush(Colors.LightGray);
                rec20.Fill = new SolidColorBrush(Colors.LightGray);
                rec27.Fill = new SolidColorBrush(Colors.LightGray);
                rec21.Fill = new SolidColorBrush(Colors.LightGray);
                rec22.Fill = new SolidColorBrush(Colors.LightGray);
                rec23.Fill = new SolidColorBrush(Colors.LightGray);
                rec24.Fill = new SolidColorBrush(Colors.LightGray);
                rec25.Fill = new SolidColorBrush(Colors.LightGray);
                rec26.Fill = new SolidColorBrush(Colors.LightGray);

                rec5.Fill = new SolidColorBrush(Colors.LightGray);
                rec16.Fill = new SolidColorBrush(Colors.LightGray);
                rec15.Fill = new SolidColorBrush(Colors.LightGray);
                rec14.Fill = new SolidColorBrush(Colors.LightGray);
                rec6.Fill = new SolidColorBrush(Colors.LightGray);
                rec13.Fill = new SolidColorBrush(Colors.LightGray);
                rec7.Fill = new SolidColorBrush(Colors.LightGray);
                rec12.Fill = new SolidColorBrush(Colors.LightGray);
                rec8.Fill = new SolidColorBrush(Colors.LightGray);
                rec9.Fill = new SolidColorBrush(Colors.LightGray);
                rec10.Fill = new SolidColorBrush(Colors.LightGray);
                rec11.Fill = new SolidColorBrush(Colors.LightGray);

            }


            if (op2.IsSelected)
            {
                rec36.Fill = new SolidColorBrush(Colors.LightGray);
                rec35.Fill = new SolidColorBrush(Colors.LightGray);
                rec34.Fill = new SolidColorBrush(Colors.LightGray);
                rec33.Fill = new SolidColorBrush(Colors.LightGray);
                rec32.Fill = new SolidColorBrush(Colors.LightGray);
                rec31.Fill = new SolidColorBrush(Colors.LightGray);
                rec17.Fill = new SolidColorBrush(Colors.LightGray);
                rec30.Fill = new SolidColorBrush(Colors.LightGray);
                rec18.Fill = new SolidColorBrush(Colors.LightGray);
                rec29.Fill = new SolidColorBrush(Colors.LightGray);
                rec19.Fill = new SolidColorBrush(Colors.LightGray);
                rec28.Fill = new SolidColorBrush(Colors.LightGray);
                rec20.Fill = new SolidColorBrush(Colors.LightGray);
                rec27.Fill = new SolidColorBrush(Colors.LightGray);
                rec21.Fill = new SolidColorBrush(Colors.LightGray);
                rec22.Fill = new SolidColorBrush(Colors.LightGray);
                rec23.Fill = new SolidColorBrush(Colors.LightGray);
                rec24.Fill = new SolidColorBrush(Colors.LightGray);
                rec25.Fill = new SolidColorBrush(Colors.LightGray);
                rec26.Fill = new SolidColorBrush(Colors.LightGray);
            }

            if (op3.IsSelected)
            {

            }

        }
        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

    }
}
