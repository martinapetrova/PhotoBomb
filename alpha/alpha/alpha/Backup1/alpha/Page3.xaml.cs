using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Xna.Framework.Media;


namespace alpha
{
    

    public partial class Page3 : PhoneApplicationPage
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            image1.Clip = null;
            image1.OpacityMask = null;
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
        new Uri("/Page2.xaml", UriKind.Relative));
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            RadialGradientBrush brush = new RadialGradientBrush();
            GradientStop gr1 = new GradientStop();
            gr1.Color = Colors.White;
            gr1.Offset = 0.1;
            GradientStop gr2 = new GradientStop();
            gr2.Color = Colors.Transparent;
            gr2.Offset = 0.9;
            brush.GradientStops.Add(gr1);
            brush.GradientStops.Add(gr2);
            brush.Center = new Point(0.5, 0.5);
            brush.GradientOrigin = new Point(0.5, 0.5);
            brush.RadiusX = 0.75;
            brush.RadiusY = 0.75;
            image1.OpacityMask = brush;
        }

        private void image1_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }
        private void image1_ManipulationStarted(object sender, ManipulationStartedEventArgs e)
        {
            EllipseGeometry elip = new EllipseGeometry();
            elip.Center = new Point(e.ManipulationOrigin.X, e.ManipulationOrigin.Y);
            elip.RadiusX = image1.Width / 3.5;
            elip.RadiusY = image1.Height / 3.5;
            image1.Clip = elip;
            e.Complete();
            e.Handled = true;
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            RadialGradientBrush brush = new RadialGradientBrush();
            GradientStop gr1 = new GradientStop();
            gr1.Color = Colors.White;
            gr1.Offset = 0.1;
            GradientStop gr2 = new GradientStop();
            gr2.Color = Colors.Transparent;
            gr2.Offset = 0.9;
            brush.GradientStops.Add(gr1);
            brush.GradientStops.Add(gr2);
            brush.Center = new Point(0.5, 0.5);
            brush.GradientOrigin = new Point(0.5, 0.5);
            brush.RadiusX = 0.35;
            brush.RadiusY = 1;
            image1.OpacityMask = brush;
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
        new Uri("/Page4.xaml", UriKind.Relative));
        }
    }
}