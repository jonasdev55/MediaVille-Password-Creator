using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MediaVille_Password_Creator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool useUppercase;
        bool useNumbers;
        bool useSymbols;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void Uppercase_Click(object sender, RoutedEventArgs e)
        {
            if (useUppercase == false)
            {
                useUppercase = true;
                //#AFFC41
                Uppercase.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xAF, 0xFC, 0x41));
                Uppercase.Foreground = Brushes.Black;
            }
            else
            {
                useUppercase = false;
                //#30323D
                Uppercase.Background = Brushes.Transparent;
                Uppercase.Foreground = Brushes.White;
            }
        }

        public void Numbers_Click(object sender, RoutedEventArgs e)
        {
            if (useNumbers == false)
            {
                useNumbers = true;
                Numbers.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xAF, 0xFC, 0x41));
                Numbers.Foreground = Brushes.Black;
            }
            else
            {
                useNumbers = false;
                Numbers.Background = Brushes.Transparent;
                Numbers.Foreground = Brushes.White;
            }
        }

        public void Symbols_Click(object sender, RoutedEventArgs e)
        {
            if (useSymbols == false)
            {
                useSymbols = true;
                Symbols.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xAF, 0xFC, 0x41));
                Symbols.Foreground = Brushes.Black;
            }
            else
            {
                useSymbols = false;
                Symbols.Background = Brushes.Transparent;
                Symbols.Foreground = Brushes.White;
            }
        }

        public void GeneratePassword_Click(object sender, RoutedEventArgs e)
        {
            string password = "";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numbers = "0123456789";
            string symbols = "!@#$%^&*()_+{}|:<>?~`-=[]\\;',./";

            if (useUppercase == true)
            {
                lowercase += uppercase;
            }

            if (useNumbers == true)
            {
                lowercase += numbers;
            }

            if (useSymbols == true)
            {
                lowercase += symbols;
            }

            Random random = new Random();

            for (int i = 0; i < PasswordLengthSlider.Value; i++)
            {
                password += lowercase[random.Next(0, lowercase.Length)];
            }

            Password.Content = password;
        }
    }
}
