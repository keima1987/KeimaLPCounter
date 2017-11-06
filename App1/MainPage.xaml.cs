using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int LP1 = 8000;
        int LP2 = 8000;
        int LP3 = 8000;
        int LP4 = 8000;
        int MaxLP = 8000;

        public MainPage()
        {
            this.InitializeComponent();

        } 

        private async void btnNew_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog1 dialog = new ContentDialog1();
            var dlg = await dialog.ShowAsync();

            if (dlg == ContentDialogResult.Primary)
            {
                int PlayerNumber = dialog.PlayerNumber;

                switch (PlayerNumber)
                {
                    case 0:
                        {
                            lblName1.Text = dialog.Player1;
                            lblName2.Text = dialog.Player2;
                            lblName3.Text = "none";
                            lblName4.Text = "none";
                            lblName3.Opacity = 50;
                            lblName4.Opacity = 50;
                            MaxLP = Int32.Parse(dialog.LifePoints);
                            LP1 = Int32.Parse(dialog.LifePoints);
                            LP2 = Int32.Parse(dialog.LifePoints);
                            LP3 = 0;
                            LP4 = 0;
                            lblLP1.Text = dialog.LifePoints;
                            lblLP2.Text = dialog.LifePoints;
                            lblLP3.Text = "-";
                            lblLP4.Text = "-";
                            lblLP3.Opacity = 50;
                            lblLP4.Opacity = 50;
                            pbLP1.Maximum = double.Parse(dialog.LifePoints);
                            pbLP1.Value = double.Parse(dialog.LifePoints);
                            pbLP2.Maximum = double.Parse(dialog.LifePoints);
                            pbLP2.Value = double.Parse(dialog.LifePoints);
                            pbLP3.Maximum = double.Parse(dialog.LifePoints);
                            pbLP3.Value = double.Parse(dialog.LifePoints); ;
                            pbLP4.Maximum = double.Parse(dialog.LifePoints); ;
                            pbLP4.Value = double.Parse(dialog.LifePoints); ;
                            pbLP3.Opacity = 50;
                            pbLP4.Opacity = 50;
                            edtLP3.IsEnabled = false;
                            edtLP4.IsEnabled = false;
                            btnLPRem1.IsEnabled = true;
                            btnLPAdd1.IsEnabled = true;
                            btnLPRem2.IsEnabled = true;
                            btnLPAdd2.IsEnabled = true;
                            btnLPRem3.IsEnabled = false;
                            btnLPAdd3.IsEnabled = false;
                            btnLPRem4.IsEnabled = false;
                            btnLPAdd4.IsEnabled = false;
                            lblLP1.Foreground = new SolidColorBrush(Windows.UI.Colors.Black);
                            lblLP2.Foreground = new SolidColorBrush(Windows.UI.Colors.Black);
                            lblLP3.Foreground = new SolidColorBrush(Windows.UI.Colors.Black);
                            lblLP4.Foreground = new SolidColorBrush(Windows.UI.Colors.Black);
                            break;
                        }
                    case 1:
                        {
                            lblName1.Text = dialog.Player1;
                            lblName2.Text = dialog.Player2;
                            lblName3.Text = dialog.Player3;
                            lblName4.Text = "none";
                            lblName3.Opacity = 100;
                            lblName4.Opacity = 50;
                            MaxLP = Int32.Parse(dialog.LifePoints);
                            LP1 = Int32.Parse(dialog.LifePoints);
                            LP2 = Int32.Parse(dialog.LifePoints);
                            LP3 = Int32.Parse(dialog.LifePoints);
                            LP4 = 0;
                            lblLP1.Text = dialog.LifePoints;
                            lblLP2.Text = dialog.LifePoints;
                            lblLP3.Text = dialog.LifePoints;
                            lblLP4.Text = "-";
                            lblLP3.Opacity = 100;
                            lblLP4.Opacity = 50;
                            pbLP1.Maximum = double.Parse(dialog.LifePoints);
                            pbLP1.Value = double.Parse(dialog.LifePoints);
                            pbLP2.Maximum = double.Parse(dialog.LifePoints);
                            pbLP2.Value = double.Parse(dialog.LifePoints);
                            pbLP3.Maximum = double.Parse(dialog.LifePoints);
                            pbLP3.Value = double.Parse(dialog.LifePoints);
                            pbLP4.Maximum = double.Parse(dialog.LifePoints); ;
                            pbLP4.Value = double.Parse(dialog.LifePoints); ;
                            pbLP3.Opacity = 100;
                            pbLP4.Opacity = 50;
                            edtLP3.IsEnabled = true;
                            edtLP4.IsEnabled = false;
                            btnLPRem1.IsEnabled = true;
                            btnLPAdd1.IsEnabled = true;
                            btnLPRem2.IsEnabled = true;
                            btnLPAdd2.IsEnabled = true;
                            btnLPRem3.IsEnabled = true;
                            btnLPAdd3.IsEnabled = true;
                            btnLPRem4.IsEnabled = false;
                            btnLPAdd4.IsEnabled = false;
                            lblLP1.Foreground = new SolidColorBrush(Windows.UI.Colors.Black);
                            lblLP2.Foreground = new SolidColorBrush(Windows.UI.Colors.Black);
                            lblLP3.Foreground = new SolidColorBrush(Windows.UI.Colors.Black);
                            lblLP4.Foreground = new SolidColorBrush(Windows.UI.Colors.Black);
                            break;
                        }
                    case 2:
                        {
                            lblName1.Text = dialog.Player1;
                            lblName2.Text = dialog.Player2;
                            lblName3.Text = dialog.Player3;
                            lblName4.Text = dialog.Player4;
                            lblName3.Opacity = 100;
                            lblName4.Opacity = 100;
                            MaxLP = Int32.Parse(dialog.LifePoints);
                            LP1 = Int32.Parse(dialog.LifePoints);
                            LP2 = Int32.Parse(dialog.LifePoints);
                            LP3 = Int32.Parse(dialog.LifePoints);
                            LP4 = Int32.Parse(dialog.LifePoints);
                            lblLP1.Text = dialog.LifePoints;
                            lblLP2.Text = dialog.LifePoints;
                            lblLP3.Text = dialog.LifePoints;
                            lblLP4.Text = dialog.LifePoints;
                            lblLP3.Opacity = 100;
                            lblLP4.Opacity = 100;
                            pbLP1.Maximum = double.Parse(dialog.LifePoints);
                            pbLP1.Value = double.Parse(dialog.LifePoints);
                            pbLP2.Maximum = double.Parse(dialog.LifePoints);
                            pbLP2.Value = double.Parse(dialog.LifePoints);
                            pbLP3.Maximum = double.Parse(dialog.LifePoints);
                            pbLP3.Value = double.Parse(dialog.LifePoints);
                            pbLP4.Maximum = double.Parse(dialog.LifePoints);
                            pbLP4.Value = double.Parse(dialog.LifePoints);
                            pbLP3.Opacity = 100;
                            pbLP4.Opacity = 100;
                            edtLP3.IsEnabled = true;
                            edtLP4.IsEnabled = true;
                            btnLPRem1.IsEnabled = true;
                            btnLPAdd1.IsEnabled = true;
                            btnLPRem2.IsEnabled = true;
                            btnLPAdd2.IsEnabled = true;
                            btnLPRem3.IsEnabled = true;
                            btnLPAdd3.IsEnabled = true;
                            btnLPRem4.IsEnabled = true;
                            btnLPAdd4.IsEnabled = true;
                            lblLP1.Foreground = new SolidColorBrush(Windows.UI.Colors.Black);
                            lblLP2.Foreground = new SolidColorBrush(Windows.UI.Colors.Black);
                            lblLP3.Foreground = new SolidColorBrush(Windows.UI.Colors.Black);
                            lblLP4.Foreground = new SolidColorBrush(Windows.UI.Colors.Black);
                            break;
                        }
                }
            }


        }

        private void btnLPAdd1_Click(object sender, RoutedEventArgs e)
        {
            LP1 = LP1 + Int32.Parse(edtLP1.Text);
            lblLP1.Text = LP1.ToString();
            if (LP1 < MaxLP)
            {
                pbLP1.Value = LP1;
            }
            else
            {
                pbLP1.Value = 8000;
            }
        }

        private void btnLPAdd2_Click(object sender, RoutedEventArgs e)
        {
            LP2 = LP2 + Int32.Parse(edtLP2.Text);
            lblLP2.Text = LP2.ToString();
            if (LP2 < MaxLP)
            {
                pbLP2.Value = LP2;
            }
            else
            {
                pbLP2.Value = 8000;
            }
        }

        private void btnLPAdd3_Click(object sender, RoutedEventArgs e)
        {
            LP3 = LP3 + Int32.Parse(edtLP3.Text);
            lblLP3.Text = LP3.ToString();
            if (LP3 < MaxLP)
            {
                pbLP3.Value = LP3;
            }
            else
            {
                pbLP3.Value = 8000;
            }
        }

        private void btnLPAdd4_Click(object sender, RoutedEventArgs e)
        {
            LP4 = LP4 + Int32.Parse(edtLP4.Text);
            lblLP4.Text = LP4.ToString();
            if (LP4 < MaxLP)
            {
                pbLP4.Value = LP4;
            }
            else
            {
                pbLP4.Value = 8000;
            }
        }

        private void btnLPRem1_Click(object sender, RoutedEventArgs e)
        {
            LP1 = LP1 - Int32.Parse(edtLP1.Text);

            if (LP1 > 0)
            {
                lblLP1.Text = LP1.ToString();
                pbLP1.Value = LP1;
            }
            else
            {
                lblLP1.Text = "0";
                lblLP1.Foreground = new SolidColorBrush(Windows.UI.Colors.Red);
                pbLP1.Value = 0;
                edtLP1.IsEnabled = false;
                btnLPRem1.IsEnabled = false;
                btnLPAdd1.IsEnabled = false;
            }
        }

        private void btnLPRem2_Click(object sender, RoutedEventArgs e)
        {
            LP2 = LP2 - Int32.Parse(edtLP2.Text);

            if (LP2 > 0)
            {
                lblLP2.Text = LP2.ToString();
                pbLP2.Value = LP2;
            }
            else
            {
                lblLP2.Text = "0";
                lblLP2.Foreground = new SolidColorBrush(Windows.UI.Colors.Red);
                pbLP2.Value = 0;
                edtLP2.IsEnabled = false;
                btnLPRem2.IsEnabled = false;
                btnLPAdd2.IsEnabled = false;
            }
        }

        private void btnLPRem3_Click(object sender, RoutedEventArgs e)
        {
            LP3 = LP3 - Int32.Parse(edtLP3.Text);

            if (LP3 > 0)
            {
                lblLP3.Text = LP3.ToString();
                pbLP3.Value = LP3;
            }
            else
            {
                lblLP3.Text = "0";
                pbLP3.Value = 0;
                lblLP3.Foreground = new SolidColorBrush(Windows.UI.Colors.Red);
                edtLP3.IsEnabled = false;
                btnLPRem3.IsEnabled = false;
                btnLPAdd3.IsEnabled = false;
            }
        }

        private void btnLPRem4_Click(object sender, RoutedEventArgs e)
        {
            LP4 = LP4 - Int32.Parse(edtLP4.Text);

            if (LP4 > 0)
            {
                lblLP4.Text = LP4.ToString();
                pbLP4.Value = LP4;
            }
            else
            {
                lblLP4.Text = "0";
                lblLP4.Foreground = new SolidColorBrush(Windows.UI.Colors.Red);
                pbLP4.Value = 0;
                edtLP4.IsEnabled = false;
                btnLPRem4.IsEnabled = false;
                btnLPAdd4.IsEnabled = false;
            }
        }

        private void pgMain_Loaded(object sender, RoutedEventArgs e)
        {
            btnNew_Click(sender, e);
        }
    }
}