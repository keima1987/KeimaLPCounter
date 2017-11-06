using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    public sealed partial class ContentDialog1 : ContentDialog
    {
        public ContentDialog1()
        {
            this.InitializeComponent();
        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }

        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }

        public int PlayerNumber { get { return cbPlayerNumber.SelectedIndex; } }
        public string LifePoints { get { return edtLP.Text; } }
        public string Player1 { get { return edtPlayer1.Text; } }
        public string Player2 { get { return edtPlayer2.Text; } }
        public string Player3 { get { return edtPlayer3.Text; } }
        public string Player4 { get { return edtPlayer4.Text; } }

        private void cbPlayerNumber_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int PlayerNumber = cbPlayerNumber.SelectedIndex;
            switch (PlayerNumber) {
                case 0:
                    {
                        edtPlayer3.IsEnabled = false;
                        edtPlayer4.IsEnabled = false;
                        break;
                    }
                case 1:
                    {
                        edtPlayer3.IsEnabled = true;
                        edtPlayer4.IsEnabled = false;
                        break;
                    }
                case 2:
                    {
                        edtPlayer3.IsEnabled = true;
                        edtPlayer4.IsEnabled = true;
                        break;
                    }
            }
        }
    }
}
