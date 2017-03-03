
using System.Threading.Tasks;
using Windows.Foundation;
using System;
using Windows.System.Profile;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Popups;
using System.Collections.Generic;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409
//Binding colores: https://social.msdn.microsoft.com/Forums/vstudio/en-US/2f40843a-b7b6-4613-ad22-367ca855e765/binding-fill-color-of-rectangle-to-a-color?forum=wpf
/*
TODO    
OK: que se cambie de color al original tras el flash (Mercedes) 
OK: cambiar flash: opacity, visibility o un color y hacer que vuelva a la normalidadn (Mercedes)
guardar las secuencia de maquina y usuario (Mercedes)
OK: iniciar flash al comienzo (Alvaro)
Game over: embolia de flash y mensaje de Game Over sobre el tablero si se puede (message box transparente??) (Carlos)
OK: Hay que poner un play o algo y evitar que se empiece justo al cargar, usar btn Refresh en vez de play?? o poner 2 btns??
deshabilitar play hasta que le de a refresh (2 btns)

Extras v.63.2:
Añadir sonidos al flash de la maquina y al click de la persona
El boton de reinicio debe reiniciarse en el nivel en que estaba, no siempre en el Normal
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
        int turno = 0;
        List<int> secuenciaMaquina = new List<int>(); //aqui guardo la secuencia de flash
        int tapContador=0;
        int tamanno= 0;


        public MainPage()
        {

            this.InitializeComponent();
            //btnjugar.IsEnabled = false;
            //btnRefresh.IsEnabled = false;

            
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
        }
        private void comboNivel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnjugar.IsEnabled = true;
        
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
            }

        }

        /// <summary>
        /// Metodo que se encarga de pintar el rectangulo de gris para que el usuario sepa que rectangulo tiene que pulsar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void rect_tapped(object sender, TappedRoutedEventArgs e)
        {

                Rectangle rectanClicked = sender as Rectangle;

                Brush colorPrevio = rectanClicked.Fill;

                rectanClicked.Fill = new SolidColorBrush(Colors.LightGray);
                await Task.Delay(250);
                rectanClicked.Fill = colorPrevio;

                int rectanguloElegido = Int32.Parse(rectanClicked.Tag.ToString());

                if (secuenciaMaquina[tapContador] == rectanguloElegido)
                {
                    tapContador++;
                    haGanado = true;



                    if (tapContador == secuenciaMaquina.Count)
                    {
                        txtScore.Text = turno.ToString();
                        start(tamanno);
                    }


                }
                else
                {
                    haGanado = false;
                    mostrarMensaje();
                }
        }

        
        /// <summary>
        /// Metodo que pinta un rectangulo aleatorio dentro del tablero
        /// </summary>
        /// <param name="numRango">Numero total de rectangulos que hay en el tablero que el usuario ha elegido</param>
        public async void pintarRectangulo(int numRango)
        {
            await Task.Delay(500);
            Random random = new Random();
            rectPintar = random.Next(1, numRango);
            await Task.Delay(500);
            secuenciaFlash(rectPintar);
            //guardo el Tag del rectangulo que pinto
            secuenciaMaquina.Add(rectPintar);
            await Task.Delay(500);
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
            await Task.Delay(500);
            Brush colorPrevio = rectangulo.Fill;

            rectangulo.Fill = new SolidColorBrush(Color.FromArgb(255, 252, 11, 147));//(249, 4, 225) //(3, 236, 249) 
            //COLOR DE LA BARRA//77, 182, 172 //(183, 225, 221) //(147, 210, 204) // (45, 108, 102)
            // rectangulo.Visibility = Visibility.Collapsed; //000-247-000 //252, 11, 147
            await Task.Delay(500);
            rectangulo.Fill = colorPrevio;
        }


        //http://stackoverflow.com/questions/38110972/how-to-find-a-control-with-a-specific-name-in-an-xaml-ui-with-c-sharp-code
        /// <summary>
        /// Metodo que busca un control con un nombre concreto en todo el xaml dependiendo del tipo de control que sea
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="parent"></param>
        /// <param name="targetType"></param>
        /// <param name="ControlName"></param>
        /// <returns></returns>
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
        /// Metodo que muestra un mensaje de error cuando el usuario falla
        /// </summary>
        public async void mostrarMensaje()
        {
            var dialog = new MessageDialog("Has perdidoooooo :((((((");
            await dialog.ShowAsync();
        }
        /// <summary>
        /// Metodo que reinicia la actividad principal después de pulsar el btn de jugar de nuevo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }


        /// <summary>
        /// SE CORRESPONDE CON EL BTN PLAY EN EL XAML
        /// Metodo que se ejecuta despues de que el usuario pulse el btn de jugar
        /// Cuando pulsa jugar se pintan los recuadros aleatorios, llamando al metodo pintarRectangulo y el numero total de rectangulos de ese tablero
        /// Otra accion que realiza es que bloquea el combobox y pone enabled el btn para jugar de nuevo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnjugar_Click(object sender, RoutedEventArgs e)
        {
            btnJuegoNuevo.IsEnabled = true;
            btnjugar.IsEnabled = false;
            comboNivel.IsEnabled = false;

            if (op1.IsSelected)
            {
                tamanno = 4;

            } else if (op2.IsSelected)
                {
                    tamanno = 16;
                }
                else if (op3.IsSelected)
                {
                    tamanno = 36;
                }

                start(tamanno);
            }
                        

        /// <summary>
        /// Metodo que inicia el juego, se llamara desde btnJugar_Click
        /// </summary>
        private async void start(int tamanno)
        {

            for (int i = 1; i<=tamanno; i++) {
                String nombreRectangulo = "rec" + i;
                var rectangulo = MainPage.FindControl<Rectangle>(this, typeof(Rectangle), nombreRectangulo);
                rectangulo.IsTapEnabled = false;
            }

            if (secuenciaMaquina.Count == 0) {
                    pintarRectangulo(tamanno); //añade el tag a secuenciaMaquina y llama a secuenciaFlash()
                    turno++;
                for (int i = 1; i <= tamanno; i++)
                {
                    String nombreRectangulo = "rec" + i;
                    var rectangulo = MainPage.FindControl<Rectangle>(this, typeof(Rectangle), nombreRectangulo);
                    rectangulo.IsTapEnabled = true;
                }
            } else {

                    for (int i = 0; i <turno; i++)
                    {
                        await Task.Delay(500);
                        secuenciaFlash(secuenciaMaquina[i]);//pintamos los rectangulos guardados en secuenciaMaquina 
                        await Task.Delay(500);          
                    }
                     pintarRectangulo(tamanno);//añade el tag a secuenciaMaquina y llama a secuenciaFlash()
                     turno++;
                for (int i = 1; i <= tamanno; i++)
                {
                    String nombreRectangulo = "rec" + i;
                    var rectangulo = MainPage.FindControl<Rectangle>(this, typeof(Rectangle), nombreRectangulo);
                    rectangulo.IsTapEnabled = true;
                }
            }

            tapContador = 0;
        }

    }
   
}
