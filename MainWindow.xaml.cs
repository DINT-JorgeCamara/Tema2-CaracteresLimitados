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

namespace Tema2_CaracteresLimitados
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        const int MAX_CARACTERES = 140;

        private void TextoUsuario_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TextoUsuario_TextBox.Text.Length <= MAX_CARACTERES)
                ContadorPalabras_TextBlock.Text = TextoUsuario_TextBox.Text.Length.ToString() + "/140";
            else TextoUsuario_TextBox.IsReadOnly = true;
        }
    }
}
