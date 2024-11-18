using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup.Localizer;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Xml.Schema;

namespace Mastermind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Globale variable

        int colorCode1 = 0;
        int colorCode2 = 0;
        int colorCode3 = 0;
        int colorCode4 = 0;

        int attempts = 0;

        DispatcherTimer timer= new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void code1ComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (code1ComboBox.Text == "Red")
            {
                code1Label.Background = Brushes.Red;
            }
            else if (code1ComboBox.Text == "Green")
            {
                code1Label.Background = Brushes.Green;
            }
            else if (code1ComboBox.Text == "Blue")
            {
                code1Label.Background = Brushes.Blue;
            }
            else if (code1ComboBox.Text == "Yellow")
            {
                code1Label.Background = Brushes.Yellow;
            }
            else if (code1ComboBox.Text == "Orange")
            {
                code1Label.Background = Brushes.Orange;
            }
            else if (code1ComboBox.Text == "White")
            {
                code1Label.Background = Brushes.White;
            }
            else
            {
                code1Label.Background = Brushes.Transparent;
            }

            code1Label.BorderBrush = code1Label.Background;
        }

        private void code2ComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (code2ComboBox.Text == "Red")
            {
                code2Label.Background = Brushes.Red;
            }
            else if (code2ComboBox.Text == "Green")
            {
                code2Label.Background = Brushes.Green;
            }
            else if (code2ComboBox.Text == "Blue")
            {
                code2Label.Background = Brushes.Blue;
            }
            else if (code2ComboBox.Text == "Yellow")
            {
                code2Label.Background = Brushes.Yellow;
            }
            else if (code2ComboBox.Text == "Orange")
            {
                code2Label.Background = Brushes.Orange;
            }
            else if (code2ComboBox.Text == "White")
            {
                code2Label.Background = Brushes.White;
            }
            else
            {
                code2Label.Background = Brushes.Transparent;
            }

            code2Label.BorderBrush = code2Label.Background;
        }

        private void code3ComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (code3ComboBox.Text == "Red")
            {
                code3Label.Background = Brushes.Red;
            }
            else if (code3ComboBox.Text == "Green")
            {
                code3Label.Background = Brushes.Green;
            }
            else if (code3ComboBox.Text == "Blue")
            {
                code3Label.Background = Brushes.Blue;
            }
            else if (code3ComboBox.Text == "Yellow")
            {
                code3Label.Background = Brushes.Yellow;
            }
            else if (code3ComboBox.Text == "Orange")
            {
                code3Label.Background = Brushes.Orange;
            }
            else if (code3ComboBox.Text == "White")
            {
                code3Label.Background = Brushes.White;
            }
            else
            {
                code3Label.Background = Brushes.Transparent;
            }

            code3Label.BorderBrush = code3Label.Background;
        }

        private void code4ComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (code4ComboBox.Text == "Red")
            {
                code4Label.Background = Brushes.Red;
            }
            else if (code4ComboBox.Text == "Green")
            {
                code4Label.Background = Brushes.Green;
            }
            else if (code4ComboBox.Text == "Blue")
            {
                code4Label.Background = Brushes.Blue;
            }
            else if (code4ComboBox.Text == "Yellow")
            {
                code4Label.Background = Brushes.Yellow;
            }
            else if (code4ComboBox.Text == "Orange")
            {
                code4Label.Background = Brushes.Orange;
            }
            else if (code4ComboBox.Text == "White")
            {
                code4Label.Background = Brushes.White;
            }
            else
            {
                code4Label.Background = Brushes.Transparent;
            }

            code4Label.BorderBrush = code4Label.Background;
        }

        private void generateButton_Click(object sender, RoutedEventArgs e)
        {
            attempts = 0;

            StartCountdown();

            Random rnd = new Random();

            colorCode1 = rnd.Next(0, 24);
            colorCode2 = rnd.Next(0, 24);
            colorCode3 = rnd.Next(0, 24);
            colorCode4 = rnd.Next(0, 24);

            code1ComboBox.SelectedIndex = 0;
            code2ComboBox.SelectedIndex = 0;
            code3ComboBox.SelectedIndex = 0;
            code4ComboBox.SelectedIndex = 0;

            code1Label.Background = Brushes.Transparent;
            code2Label.Background = Brushes.Transparent;
            code3Label.Background = Brushes.Transparent;
            code4Label.Background = Brushes.Transparent;

            code1Label.BorderBrush = Brushes.Transparent;
            code2Label.BorderBrush = Brushes.Transparent;
            code3Label.BorderBrush = Brushes.Transparent;
            code4Label.BorderBrush = Brushes.Transparent;

            MastermindWindow.Title = "Mastermind";

            switch (colorCode1 % 6)
            {
                case 0:
                    MastermindWindow.Title += "\tRed,";
                    colorCode1 = 1;
                    break;
                case 1:
                    MastermindWindow.Title += "\tYellow,";
                    colorCode1 = 2;
                    break;
                case 2:
                    MastermindWindow.Title += "\tOrange,";
                    colorCode1 = 3;
                    break;
                case 3:
                    MastermindWindow.Title += "\tWhite,";
                    colorCode1 = 4;
                    break;
                case 4:
                    MastermindWindow.Title += "\tGreen,";
                    colorCode1 = 5;
                    break;
                case 5:
                    MastermindWindow.Title += "\tBlue,";
                    colorCode1 = 6;
                    break;
            }



            switch (colorCode2 % 6)
            {
                case 0:
                    MastermindWindow.Title += " Red,";
                    colorCode2 = 1;
                    break;
                case 1:
                    MastermindWindow.Title += " Yellow,";
                    colorCode2 = 2;
                    break;
                case 2:
                    MastermindWindow.Title += " Orange,";
                    colorCode2 = 3;
                    break;
                case 3:
                    MastermindWindow.Title += " White,";
                    colorCode2 = 4;
                    break;
                case 4:
                    MastermindWindow.Title += " Green,";
                    colorCode2 = 5;
                    break;
                case 5:
                    MastermindWindow.Title += " Blue,";
                    colorCode2 = 6;
                    break;
            }

            switch (colorCode3 % 6)
            {
                case 0:
                    MastermindWindow.Title += " Red,";
                    colorCode3 = 1;
                    break;
                case 1:
                    MastermindWindow.Title += " Yellow,";
                    colorCode3 = 2;
                    break;
                case 2:
                    MastermindWindow.Title += " Orange,";
                    colorCode3 = 3;
                    break;
                case 3:
                    MastermindWindow.Title += " White,";
                    colorCode3 = 4;
                    break;
                case 4:
                    MastermindWindow.Title += " Green,";
                    colorCode3 = 5;
                    break;
                case 5:
                    MastermindWindow.Title += " Blue,";
                    colorCode3 = 6;
                    break;
            }

            switch (colorCode4 % 6)
            {
                case 0:
                    MastermindWindow.Title += " Red";
                    colorCode4 = 1;
                    break;
                case 1:
                    MastermindWindow.Title += " Yellow";
                    colorCode4 = 2;
                    break;
                case 2:
                    MastermindWindow.Title += " Orange";
                    colorCode4 = 3;
                    break;
                case 3:
                    MastermindWindow.Title += " White";
                    colorCode4 = 4;
                    break;
                case 4:
                    MastermindWindow.Title += " Green";
                    colorCode4 = 5;
                    break;
                case 5:
                    MastermindWindow.Title += " Blue";
                    colorCode4 = 6;
                    break;
            }

            debugTextBox.Text = MastermindWindow.Title.Substring(MastermindWindow.Title.IndexOf("\t") + 1);
            controlButton.IsEnabled = true;

            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            StopCountdown();
        }

        private void StopCountdown()
        {
            /// <summary>
            /// The timer = stoped and
            /// attemps + 1
            /// </summary>
            
            attempts++;

            if (MastermindWindow.Title.IndexOf("Poging")>0)
            {
                MastermindWindow.Title = MastermindWindow.Title.Substring(0, MastermindWindow.Title.IndexOf("Poging"));
                MastermindWindow.Title += $"Poging {attempts}"; 
            }
            else
            {
                MastermindWindow.Title += $"\tPoging {attempts}";
            }
            

            timer.Stop();
        }

        private void StartCountdown()
        {
            /// <summary>
            /// The timer = started and
            /// from in generateButton_Click or
            /// from in controlButton_Click
            /// </summary>

            timer.Start();
        }

        private void controlButton_Click(object sender, RoutedEventArgs e)
        {
            // Resetten booleans

            bool colorPosition1 = false;
            bool colorPosition2 = false;
            bool colorPosition3 = false;
            bool colorPosition4 = false;

            bool color1 = false;
            bool color2 = false;
            bool color3 = false;
            bool color4 = false;

            // resetten randen

            code1Label.BorderBrush = code1Label.Background;
            code2Label.BorderBrush = code2Label.Background;
            code3Label.BorderBrush = code3Label.Background;
            code4Label.BorderBrush = code4Label.Background;

            //Controle of elke positie een kleur heeft

            if (code1ComboBox.SelectedIndex > 0 &&
                code2ComboBox.SelectedIndex > 0 &&
                code3ComboBox.SelectedIndex > 0 &&
                code4ComboBox.SelectedIndex > 0)
            {
                //Controleren juiste kleur op juiste plaats

                if (colorCode1 == code1ComboBox.SelectedIndex)
                {
                    code1Label.BorderBrush = Brushes.DarkRed;
                    colorPosition1 = true;
                    color1 = true;
                }

                if (colorCode2 == code2ComboBox.SelectedIndex)
                {
                    code2Label.BorderBrush = Brushes.DarkRed;
                    colorPosition2 = true;
                    color2 = true;
                }

                if (colorCode3 == code3ComboBox.SelectedIndex)
                {
                    code3Label.BorderBrush = Brushes.DarkRed;
                    colorPosition3 = true;
                    color3 = true;
                }

                if (colorCode4 == code4ComboBox.SelectedIndex)
                {
                    code4Label.BorderBrush = Brushes.DarkRed;
                    colorPosition4 = true;
                    color4 = true;
                }

                // Checken of de kleur ergens anders voorkomt

                if (colorPosition1 == false)
                {
                    if (code1ComboBox.SelectedIndex == colorCode2 && color2 == false)
                    {
                        code1Label.BorderBrush = Brushes.Wheat;
                        color2 = true;
                    }
                    else if (code1ComboBox.SelectedIndex == colorCode3 && color3 == false)
                    {
                        code1Label.BorderBrush = Brushes.Wheat;
                        color3 = true;
                    }
                    else if (code1ComboBox.SelectedIndex == colorCode4 && color4 == false)
                    {
                        code1Label.BorderBrush = Brushes.Wheat;
                        color4 = true;
                    }
                }

                if (colorPosition2 == false)
                {
                    if (code2ComboBox.SelectedIndex == colorCode1 && color1 == false)
                    {
                        code2Label.BorderBrush = Brushes.Wheat;
                        color1 = true;
                    }
                    else if (code2ComboBox.SelectedIndex == colorCode3 && color3 == false)
                    {
                        code2Label.BorderBrush = Brushes.Wheat;
                        color3 = true;
                    }
                    else if (code2ComboBox.SelectedIndex == colorCode4 && color4 == false)
                    {
                        code2Label.BorderBrush = Brushes.Wheat;
                        color4 = true;
                    }
                }

                if (colorPosition3 == false)
                {
                    if (code3ComboBox.SelectedIndex == colorCode1 && color1 == false)
                    {
                        code3Label.BorderBrush = Brushes.Wheat;
                        color1 = true;
                    }
                    else if (code3ComboBox.SelectedIndex == colorCode2 && color2 == false)
                    {
                        code3Label.BorderBrush = Brushes.Wheat;
                        color2 = true;
                    }
                    else if (code3ComboBox.SelectedIndex == colorCode4 && color4 == false)
                    {
                        code3Label.BorderBrush = Brushes.Wheat;
                        color4 = true;
                    }
                }

                if (colorPosition4 == false)
                {
                    if (code4ComboBox.SelectedIndex == colorCode1 && color1 == false)
                    {
                        code4Label.BorderBrush = Brushes.Wheat;
                        color1 = true;
                    }
                    else if (code4ComboBox.SelectedIndex == colorCode2 && color2 == false)
                    {
                        code4Label.BorderBrush = Brushes.Wheat;
                        color2 = true;
                    }
                    else if (code4ComboBox.SelectedIndex == colorCode3 && color3 == false)
                    {
                        code4Label.BorderBrush = Brushes.Wheat;
                        color3 = true;
                    }
                }

                attempts += 1;

                if (MastermindWindow.Title.IndexOf("\tPoging") > 0)
                {
                    MastermindWindow.Title = MastermindWindow.Title.Substring(0, MastermindWindow.Title.IndexOf("Poging"));
                    MastermindWindow.Title += $"Poging {attempts}";
                }
                else
                {
                    MastermindWindow.Title += $"\tPoging {attempts}";
                }

                StartCountdown();
            }
            else
            {
                MessageBox.Show("Maak een keuze voor alle vakken", "Keuze");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            debugTextBox.Visibility = Visibility.Hidden;


            code1ComboBox.Items.Add("");
            code2ComboBox.Items.Add("");
            code3ComboBox.Items.Add("");
            code4ComboBox.Items.Add("");

            for (int i = 1; i < 7; i++)
            {
                if (i == 1)
                {
                    code1ComboBox.Items.Add("Red");
                    code2ComboBox.Items.Add("Red");
                    code3ComboBox.Items.Add("Red");
                    code4ComboBox.Items.Add("Red");
                }
                else if (i == 2)
                {
                    code1ComboBox.Items.Add("Yellow");
                    code2ComboBox.Items.Add("Yellow");
                    code3ComboBox.Items.Add("Yellow");
                    code4ComboBox.Items.Add("Yellow");
                }
                else if (i == 3)
                {
                    code1ComboBox.Items.Add("Orange");
                    code2ComboBox.Items.Add("Orange");
                    code3ComboBox.Items.Add("Orange");
                    code4ComboBox.Items.Add("Orange");
                }
                else if (i == 4)
                {
                    code1ComboBox.Items.Add("White");
                    code2ComboBox.Items.Add("White");
                    code3ComboBox.Items.Add("White");
                    code4ComboBox.Items.Add("White");
                }
                else if (i == 5)
                {
                    code1ComboBox.Items.Add("Green");
                    code2ComboBox.Items.Add("Green");
                    code3ComboBox.Items.Add("Green");
                    code4ComboBox.Items.Add("Green");
                }
                else if (i == 6)
                {
                    code1ComboBox.Items.Add("Blue");
                    code2ComboBox.Items.Add("Blue");
                    code3ComboBox.Items.Add("Blue");
                    code4ComboBox.Items.Add("Blue");
                }
            }

            timer.Interval = new TimeSpan(0, 0, 10); //Elke Miliseconde
            timer.Tick += Timer_Tick;
        }

        private void ToggleDebug()
        {
            ///<summary>
            ///Make  visible or hidden
            /// </summary>
            if (debugTextBox.Visibility == Visibility.Visible)
            {
                debugTextBox.Visibility = Visibility.Hidden;
            }
            else
            {
                debugTextBox.Visibility = Visibility.Visible;
            }
            
        }

        private void MastermindWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F12 && e.KeyboardDevice.Modifiers == ModifierKeys.Control)
            {
                
                ToggleDebug();
            }
        }
    }

}
