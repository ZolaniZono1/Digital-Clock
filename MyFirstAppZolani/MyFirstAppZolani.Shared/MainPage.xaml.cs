using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MyFirstAppZolani
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Slider Slider = new Slider();
        public double sec; 

        public MainPage()
        {
            this.InitializeComponent();
               
        }

        private void SliderValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            SldSeconds.ValueChanged += SliderValueChanged;
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            while (true)
            {
                tbkHours.Text = System.DateTime.Now.Hour.ToString();
                tbkMinutes.Text = System.DateTime.Now.Minute.ToString();
                tbkSeconds.Text = System.DateTime.Now.Second.ToString();
                SldSeconds.Value = System.DateTime.Now.Second;
                await Task.Delay(15);
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
