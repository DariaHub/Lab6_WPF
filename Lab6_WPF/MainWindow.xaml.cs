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


namespace Lab6_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach (FontFamily fontFamily in Fonts.SystemFontFamilies)
            {
                // FontFamily.Source contains the font family name.
                CBox.Items.Add(fontFamily.Source);
            }

            CBox.SelectedIndex = 0;

        }

        private void CBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TB.FontFamily = new FontFamily(CBox.SelectedItem.ToString());
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void SizeTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TB.FontSize = Convert.ToDouble(  SizeTB.Text);
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            TB.TextDecorations = TextDecorations.Underline;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            TB.TextDecorations = null;
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            TB.FontStyle = FontStyles.Italic;
        }

        private void CheckBox_Unchecked_1(object sender, RoutedEventArgs e)
        {
            TB.FontStyle = FontStyles.Normal;
        }

        private void CheckBox_Checked_2(object sender, RoutedEventArgs e)
        {
            TB.FontWeight = FontWeights.Bold;
        }

        private void CheckBox_Unchecked_2(object sender, RoutedEventArgs e)
        {
            TB.FontWeight = FontWeights.Normal;
        }

       
    }
}
