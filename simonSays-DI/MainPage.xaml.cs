using System;
using Windows.Foundation;
using Windows.System.Profile;
using Windows.UI;
using Windows.UI.Popups;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using System.Threading.Tasks;
using Windows.UI.Xaml.Shapes;

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

<<<<<<< HEAD
            if (AnalyticsInfo.VersionInfo.DeviceFamily == "Windows.Desktop")
            {
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
            else if(AnalyticsInfo.VersionInfo.DeviceFamily == "Windows.Mobile") {

                row2.Height = new GridLength(0);
                row3.Height = new GridLength(250/2);
                row4.Height = new GridLength(250/2);
                row5.Height = new GridLength(0);

                col2.Width = new GridLength(0);
                col3.Width = new GridLength(250 /2);
                col4.Width = new GridLength(250 / 2);
                col5.Width = new GridLength(0);

            }




=======
            

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
>>>>>>> master
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


                //Aqui tengo que hacer el aleatorio hasta 4
                Random random = new Random();
                int rectPintar = random.Next(0, 3);

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

                //Aqui hay que hacer el aleatorio hasta 16

                Random random = new Random();
                int rectPintar = random.Next(0, 15);
            }

            if (op3.IsSelected)
            {
                row1.Height = new GridLength(border.Height / 6);
                row2.Height = new GridLength(border.Height / 6);
                row3.Height = new GridLength(border.Height / 6);
                row4.Height = new GridLength(border.Height / 6);
                row5.Height = new GridLength(border.Height / 6);
                row6.Height = new GridLength(border.Height / 6);

                col1.Width = new GridLength(border.Width / 6);
                col2.Width = new GridLength(border.Width / 6);
                col3.Width = new GridLength(border.Width / 6);
                col4.Width = new GridLength(border.Width / 6);
                col5.Width = new GridLength(border.Width / 6);
                col6.Width = new GridLength(border.Width / 6);


                //Aqui hay que hacer el aleatorio hasta 36
                Random random = new Random();
                int rectPintar = random.Next(0, 35);
            }

        }
        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private async void rect_tapped(object sender, TappedRoutedEventArgs e)
        {
            //MessageDialog dialog = new MessageDialog("Has pulsadoooooooooo!!!!!", "Funcionaaaaaaaaaaaaa");        
            //dialog.ShowAsync();

            Rectangle rectanClicked = sender as Rectangle;

            //switch (rectanClicked.Name)
            //{
            //    case "rec1":
            //        rec1.Fill = new SolidColorBrush(Colors.LightGray);
            //        await Task.Delay(250);
            //        rec1.Fill = new SolidColorBrush(Color.FromArgb(255, 213, 0, 0));
            //        break;
            //}   

            
            //BOTONES ROJOS
             if (rectanClicked.Name == "rec1" || rectanClicked.Name == "rec5" || rectanClicked.Name == "rec18" || rectanClicked.Name == "rec34" || rectanClicked.Name == "rec36")
            {
                rectanClicked.Fill = new SolidColorBrush(Colors.LightGray);
                await Task.Delay(250);
                rectanClicked.Fill = new SolidColorBrush(Color.FromArgb(255, 213, 0, 0));
            }
            if (rectanClicked.Name == "rec6" || rectanClicked.Name == "rec17" || rectanClicked.Name == "rec35" || rectanClicked.Name == "rec16")
            {
                rectanClicked.Fill = new SolidColorBrush(Colors.LightGray);
                await Task.Delay(250);
                rectanClicked.Fill = new SolidColorBrush(Color.FromArgb(255, 255, 46, 24));
            }

            //BOTONES VERDES
            if (rectanClicked.Name == "rec19" || rectanClicked.Name == "rec21" || rectanClicked.Name == "rec8" || rectanClicked.Name == "rec2" || rectanClicked.Name == "rec23")
            {
                rectanClicked.Fill = new SolidColorBrush(Colors.LightGray);
                await Task.Delay(250);
                rectanClicked.Fill = new SolidColorBrush(Color.FromArgb(255, 16, 124, 16));
            }
            if (rectanClicked.Name == "rec20" || rectanClicked.Name == "rec22" || rectanClicked.Name == "rec7" || rectanClicked.Name == "rec9")
            {
                rectanClicked.Fill = new SolidColorBrush(Colors.LightGray);
                await Task.Delay(250);
                rectanClicked.Fill = new SolidColorBrush(Color.FromArgb(255, 68, 195, 0));
            }

            //BOTONES AZULES
            if (rectanClicked.Name == "rec33" || rectanClicked.Name == "rec3" || rectanClicked.Name == "rec14" || rectanClicked.Name == "rec31" || rectanClicked.Name == "rec29")
            {
                rectanClicked.Fill = new SolidColorBrush(Colors.LightGray);
                await Task.Delay(250);
                rectanClicked.Fill = new SolidColorBrush(Color.FromArgb(255, 0, 120, 215));
            }
            if (rectanClicked.Name == "rec15" || rectanClicked.Name == "rec32" || rectanClicked.Name == "rec13" || rectanClicked.Name == "rec30")
            {
                rectanClicked.Fill = new SolidColorBrush(Colors.LightGray);
                await Task.Delay(250);
                rectanClicked.Fill = new SolidColorBrush(Color.FromArgb(255, 91, 131, 216));
            }

            //BOTONES AMARILLOS
            if (rectanClicked.Name == "rec4" || rectanClicked.Name == "rec24" || rectanClicked.Name == "rec11" || rectanClicked.Name == "rec28" || rectanClicked.Name == "rec26")
            {
                rectanClicked.Fill = new SolidColorBrush(Colors.LightGray);
                await Task.Delay(250);
                rectanClicked.Fill = new SolidColorBrush(Color.FromArgb(255, 255, 185, 0));
            }
            if (rectanClicked.Name == "rec10" || rectanClicked.Name == "rec12" || rectanClicked.Name == "rec27" || rectanClicked.Name == "rec25")
            {
                rectanClicked.Fill = new SolidColorBrush(Colors.LightGray);
                await Task.Delay(250);
                rectanClicked.Fill = new SolidColorBrush(Color.FromArgb(255, 255, 255, 0));
            }

        }


    }
}
