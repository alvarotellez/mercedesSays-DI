﻿using System;﻿
using System.Threading.Tasks;
using Windows.Foundation;
using System;
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
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Popups;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409
//Binding colores: https://social.msdn.microsoft.com/Forums/vstudio/en-US/2f40843a-b7b6-4613-ad22-367ca855e765/binding-fill-color-of-rectangle-to-a-color?forum=wpf
/*
TODO    
OK: que se cambie de color al original tras el flash (Mercedes)
OK: cambiar flash: opacity, visibility o un color y hacer que vuelva a la normalidadn (Mercedes)
guardar las secuencia de maquina y usuario (Alvaro)
iniciar flash al comienzo (Mercedes)
Game over: embolia de flash y mensaje de Game Over sobre el tablero si se puede (message box transparente??) (Carlos)
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

        int rectPintar;
        Boolean haGanado;
        int contador = 0;
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

                //Aqui tengo que hacer el aleatorio hasta 4
                Random random = new Random();
                 rectPintar = random.Next(1, 4);
                secuenciaFlash(rectPintar);
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

                //Aqui tengo que hacer el aleatorio hasta 4
                Random random = new Random();
                 rectPintar = random.Next(1, 4);
                secuenciaFlash(rectPintar);

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
                 rectPintar = random.Next(1, 4);
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
                rectPintar = random.Next(1, 16);
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
                    rectPintar = random.Next(1, 36);
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




            Rectangle rectanClicked = sender as Rectangle;


            

            //BOTONES ROJOS
            if (rectanClicked.Name == "rec1" || rectanClicked.Name == "rec5" || rectanClicked.Name == "rec18" || rectanClicked.Name == "rec34" || rectanClicked.Name == "rec36")




            rectanClicked = sender as Rectangle;


            int rectanguloElegido = Int32.Parse(rectanClicked.Tag.ToString());
            if (rectPintar == rectanguloElegido)
            {
                haGanado = true;
                contador++;
                txtScore.Text = contador.ToString();
            }
            else
            {
                haGanado = false;
                mostrarMensaje();
            }

            ////BOTONES ROJOS
            //if (rectanClicked.Name == "rec1" || rectanClicked.Name == "rec5" || rectanClicked.Name == "rec18" || rectanClicked.Name == "rec34" || rectanClicked.Name == "rec36")


            //BOTONES ROJOS
            if (rectanClicked.Name == "rec1" || rectanClicked.Name == "rec5" || rectanClicked.Name == "rec18" || rectanClicked.Name == "rec34" || rectanClicked.Name == "rec36")

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
        /// <summary>
        /// Metodo que avisa al usuario del rectangulo que tiene que pulsar
        /// </summary>
        /// <param name="numAleatorio"></param>
        private async void secuenciaFlash(int numAleatorio)
        {
            Rectangle rectanSelected = new Rectangle();

            String nombreRectangulo = "rec" + numAleatorio;


            


            var rectangulo = MainPage.FindControl<Rectangle>(this, typeof(Rectangle), nombreRectangulo);
            Brush colorPrevio = rectangulo.Fill;

            rectangulo.Fill = new SolidColorBrush(Color.FromArgb(255, 147, 210, 204));//(249, 4, 225) //(3, 236, 249) 
            //COLOR DE LA BARRA//77, 182, 172 //(183, 225, 221) //(147, 210, 204) // (45, 108, 102)
            // rectangulo.Visibility = Visibility.Collapsed;
            await Task.Delay(500);
            rectangulo.Fill = colorPrevio;
          //  rectangulo.Visibility = Visibility.Visible;
        }


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


        /// <summary>
        /// Método que muestra un mensaje cuando pierdes y de fondo crea la mayor epilepsia de tu vida
        /// </summary>
        private async void embolia()
        {

            Rectangle[] rectangulos = new Rectangle[] { rec1, rec2, rec3, rec4, rec5, rec6, rec7, rec8, rec9, rec10, rec11, rec12 };

            for (int i = 0; i < rectangulos.Length; i++)
            {          

                rectangulos[i].Fill = new SolidColorBrush(Colors.Red);
                await Task.Delay(100);
                rectangulos[i].Fill = new SolidColorBrush(Colors.Blue);
     
            }


            

            //rec1.Fill = new SolidColorBrush(Colors.Red);
            //await Task.Delay(100);
            //rec1.Fill = new SolidColorBrush(Colors.Blue);
            

        }

        private void btnAnimacion_Click(object sender, RoutedEventArgs e)
        {

            embolia();

        } 

        public async void mostrarMensaje()
        {
            var dialog = new MessageDialog("Has perdidoooooo :((((((");
            await dialog.ShowAsync();
        }

        private async void retrasar(int milisegundos) {
            await Task.Delay(milisegundos);

        }
    }
}
