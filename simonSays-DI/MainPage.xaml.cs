using Windows.Foundation;
using Windows.UI;
using Windows.UI.Popups;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

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
            //DEFAULT
            row1.Height = new GridLength(0);
            row2.Height = new GridLength(0);
            row3.Height = new GridLength(border.Height / 2);
            row4.Height = new GridLength(border.Height / 2);
            row5.Height = new GridLength(0);
            row6.Height = new GridLength(0);

            col1.Width = new GridLength(0);
            col2.Width = new GridLength(0);
            col3.Width = new GridLength(border.Width / 2);
            col4.Width = new GridLength(border.Width / 2);
            col5.Width = new GridLength(0);
            col6.Width = new GridLength(0);

            ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(1500, 1550));
        }
        private void comboNivel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {   

            if (op1.IsSelected)
            {
                //rec36.Fill = new SolidColorBrush(Colors.LightGray);
                //rec35.Fill = new SolidColorBrush(Colors.LightGray);
                //rec34.Fill = new SolidColorBrush(Colors.LightGray);
                //rec33.Fill = new SolidColorBrush(Colors.LightGray);
                //rec32.Fill = new SolidColorBrush(Colors.LightGray);
                //rec31.Fill = new SolidColorBrush(Colors.LightGray);
                //rec17.Fill = new SolidColorBrush(Colors.LightGray);
                //rec30.Fill = new SolidColorBrush(Colors.LightGray);
                //rec18.Fill = new SolidColorBrush(Colors.LightGray);
                //rec29.Fill = new SolidColorBrush(Colors.LightGray);
                //rec19.Fill = new SolidColorBrush(Colors.LightGray);
                //rec28.Fill = new SolidColorBrush(Colors.LightGray);
                //rec20.Fill = new SolidColorBrush(Colors.LightGray);
                //rec27.Fill = new SolidColorBrush(Colors.LightGray);
                //rec21.Fill = new SolidColorBrush(Colors.LightGray);
                //rec22.Fill = new SolidColorBrush(Colors.LightGray);
                //rec23.Fill = new SolidColorBrush(Colors.LightGray);
                //rec24.Fill = new SolidColorBrush(Colors.LightGray);
                //rec25.Fill = new SolidColorBrush(Colors.LightGray);
                //rec26.Fill = new SolidColorBrush(Colors.LightGray);

                //rec5.Fill = new SolidColorBrush(Colors.LightGray);
                //rec16.Fill = new SolidColorBrush(Colors.LightGray);
                //rec15.Fill = new SolidColorBrush(Colors.LightGray);
                //rec14.Fill = new SolidColorBrush(Colors.LightGray);
                //rec6.Fill = new SolidColorBrush(Colors.LightGray);
                //rec13.Fill = new SolidColorBrush(Colors.LightGray);
                //rec7.Fill = new SolidColorBrush(Colors.LightGray);
                //rec12.Fill = new SolidColorBrush(Colors.LightGray);
                //rec8.Fill = new SolidColorBrush(Colors.LightGray);
                //rec9.Fill = new SolidColorBrush(Colors.LightGray);
                //rec10.Fill = new SolidColorBrush(Colors.LightGray);
                //rec11.Fill = new SolidColorBrush(Colors.LightGray);

                row1.Height = new GridLength(0);
                row2.Height = new GridLength(0);
                row3.Height = new GridLength(border.Height / 2);
                row4.Height = new GridLength(border.Height / 2);
                row5.Height = new GridLength(0);
                row6.Height = new GridLength(0);

                col1.Width = new GridLength(0);
                col2.Width = new GridLength(0);
                col3.Width = new GridLength(border.Width / 2);
                col4.Width = new GridLength(border.Width / 2);
                col5.Width = new GridLength(0);
                col6.Width = new GridLength(0);


            }


            if (op2.IsSelected)
            {
                //rec36.Fill = new SolidColorBrush(Colors.LightGray);
                //rec35.Fill = new SolidColorBrush(Colors.LightGray);
                //rec34.Fill = new SolidColorBrush(Colors.LightGray);
                //rec33.Fill = new SolidColorBrush(Colors.LightGray);
                //rec32.Fill = new SolidColorBrush(Colors.LightGray);
                //rec31.Fill = new SolidColorBrush(Colors.LightGray);
                //rec17.Fill = new SolidColorBrush(Colors.LightGray);
                //rec30.Fill = new SolidColorBrush(Colors.LightGray);
                //rec18.Fill = new SolidColorBrush(Colors.LightGray);
                //rec29.Fill = new SolidColorBrush(Colors.LightGray);
                //rec19.Fill = new SolidColorBrush(Colors.LightGray);
                //rec28.Fill = new SolidColorBrush(Colors.LightGray);
                //rec20.Fill = new SolidColorBrush(Colors.LightGray);
                //rec27.Fill = new SolidColorBrush(Colors.LightGray);
                //rec21.Fill = new SolidColorBrush(Colors.LightGray);
                //rec22.Fill = new SolidColorBrush(Colors.LightGray);
                //rec23.Fill = new SolidColorBrush(Colors.LightGray);
                //rec24.Fill = new SolidColorBrush(Colors.LightGray);
                //rec25.Fill = new SolidColorBrush(Colors.LightGray);
                //rec26.Fill = new SolidColorBrush(Colors.LightGray);

                row1.Height = new GridLength(0);
                row2.Height = new GridLength(border.Height / 4);
                row3.Height = new GridLength(border.Height / 4);
                row4.Height = new GridLength(border.Height / 4);
                row5.Height = new GridLength(border.Height / 4);
                row6.Height = new GridLength(0);

                col1.Width = new GridLength(0);
                col2.Width = new GridLength(border.Width / 4);
                col3.Width = new GridLength(border.Width / 4);
                col4.Width = new GridLength(border.Width / 4);
                col5.Width = new GridLength(border.Width / 4);
                col6.Width = new GridLength(0);
            }

            if (op3.IsSelected)
            {
                row1.Height = new GridLength(border.Height/6);
                row2.Height = new GridLength(border.Height / 6);
                row3.Height = new GridLength(border.Height / 6);
                row4.Height = new GridLength(border.Height / 6);
                row5.Height = new GridLength(border.Height / 6);
                row6.Height = new GridLength(border.Height / 6);

                col1.Width = new GridLength(border.Width/6);
                col2.Width = new GridLength(border.Width / 6);
                col3.Width = new GridLength(border.Width / 6);
                col4.Width = new GridLength(border.Width / 6);
                col5.Width = new GridLength(border.Width / 6);
                col6.Width = new GridLength(border.Width / 6);

            }

        }
        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private async void rect_tapped(object sender, TappedRoutedEventArgs e)
        {
            MessageDialog dialog = new MessageDialog("Has pulsadoooooooooo!!!!!", "Funcionaaaaaaaaaaaaa");
            
            dialog.ShowAsync();

        }
    }
}
