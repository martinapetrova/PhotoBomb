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
    public interface ISaveFileDialogCompleted
    {
        void SaveFileDialogCompleted(bool okPressed, string filename);
    }

    public partial class Page4 : PhoneApplicationPage
    {
        bool okPressed;
        string filename;
        public Page4()
        {
        InitializeComponent();
        }
        public void SetTitle(string appTitle)
        {
            ApplicationTitle.Text = appTitle;
        }
        void OnTextBoxTextChanged(object sender, TextChangedEventArgs args)
        {
            saveButton.IsEnabled = txtbox.Text.Length > 0;
        }
        void OnSaveButtonClick(object sender, RoutedEventArgs args)
        {
            okPressed = true;
            filename = txtbox.Text;
            this.NavigationService.GoBack();
        }
        void OnCancelButtonClick(object sender, RoutedEventArgs args)
        {
            okPressed = false;
            this.NavigationService.GoBack();
        }
    }
}