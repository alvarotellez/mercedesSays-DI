<<<<<<< HEAD
﻿using System.Threading.Tasks;
using Windows.Foundation;
=======
﻿using System;
using Windows.Foundation;
using Windows.System.Profile;
>>>>>>> master
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
<<<<<<< HEAD
=======
using System.Threading.Tasks;
>>>>>>> master
using Windows.UI.Xaml.Shapes;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

/*
TODO    
que se cambie de color al original tras el flash
cambiar flash: opacity, visibility o un color y hacer que vuelva a la normalidad
guardar las secuencia de maquina y usuario
iniciar flash al comienzo
Game over: embolia de flash y mensaje de Game Over sobre el tablero si se puede (message box transparente??)
El boton de reinicio debe reiniciarse en el nivel en que estaba, no siempre en el Normal

Extras v.63.2:
Añadir sonidos al flash de la maquina y al click de la persona
*/
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
            else if (AnalyticsInfo.VersionInfo.DeviceFamily == "Windows.Mobile")
            {

                row2.Height = new GridLength(0);
                row3.Height = new GridLength(250 / 2);
                row4.Height = new GridLength(250 / 2);
                row5.Height = new GridLength(0);

                col2.Width = new GridLength(0);
                col3.Width = new GridLength(250 / 2);
                col4.Width = new GridLength(250 / 2);
                col5.Width = new GridLength(0);

            }


            ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(1500, 1550));
        }
        private async void comboNivel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (op1.IsSelected)
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


                //Aqui tengo que hacer el aleatorio hasta 4
                Random random = new Random();
                int rectPintar = random.Next(1, 4);
                await Task.Delay(250);
                secuenciaFlash(rectPintar);

            }


            if (op2.IsSelected)
            {

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
                int rectPintar = random.Next(1, 16);
                await Task.Delay(250);
                secuenciaFlash(rectPintar);
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
                int rectPintar = random.Next(1, 36);
                await Task.Delay(250);
                secuenciaFlash(rectPintar);

            }

        }
        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private async void rect_tapped(object sender, TappedRoutedEventArgs e)
        {
<<<<<<< HEAD
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
=======


            Rectangle rectanClicked = sender as Rectangle;
                        
            //BOTONES ROJOS
             if (rectanClicked.Name == "rec1" || rectanClicked.Name == "rec5" || rectanClicked.Name == "rec18" || rectanClicked.Name == "rec34" || rectanClicked.Name == "rec36")
>>>>>>> master
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
<<<<<<< HEAD
=======

        }
        /// <summary>
        /// Metodo que avisa al usuario del rectangulo que tiene que pulsar
        /// </summary>
        /// <param name="numAleatorio"></param>
        private void secuenciaFlash(int numAleatorio)
        {
            Rectangle rectanSelected = new Rectangle();

            String nombreRectangulo = "rec"+numAleatorio;
            
            var rectangulo = MainPage.FindControl<Rectangle>(this, typeof(Rectangle), nombreRectangulo);

            rectangulo.Fill = new SolidColorBrush(Color.FromArgb(255, 255, 255, 0));
        }
>>>>>>> master

        //http://stackoverflow.com/questions/38110972/how-to-find-a-control-with-a-specific-name-in-an-xaml-ui-with-c-sharp-code
        public static T FindControl<T>(UIElement parent, Type targetType, string ControlName) where T : FrameworkElement
        {

            if (parent == null) return null;

            if (parent.GetType() == targetType && ((T)parent).Name == ControlName)
            {
                return (T)parent;
            }
            T result = null;
            int count = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < count; i++)
            {
                UIElement child = (UIElement)VisualTreeHelper.GetChild(parent, i);

                if (FindControl<T>(child, targetType, ControlName) != null)
                {
                    result = FindControl<T>(child, targetType, ControlName);
                    break;
                }
            }
            return result;
        }
    }
}
