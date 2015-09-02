using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;

namespace alpha
{
    public partial class Page2 : PhoneApplicationPage
    {
        CameraCaptureTask camera = new CameraCaptureTask();
        public Page2()
        {
        InitializeComponent();
        camera.Completed += OnCameraCaptureTaskCompleted;
        }
        protected override void OnManipulationStarted(ManipulationStartedEventArgs args) { camera.Show();
        args.Complete();
        args.Handled = true;
        base.OnManipulationStarted(args);
        }
        void OnCameraCaptureTaskCompleted(object sender, PhotoResult args)
        {
        if (args.TaskResult == TaskResult.OK)
        {
        BitmapImage bmp = new BitmapImage(); bmp.SetSource(args.ChosenPhoto); img.Source = bmp;
        }

        
        
                }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
        new Uri("/MainPage.xaml", UriKind.Relative));
        }
    }
}