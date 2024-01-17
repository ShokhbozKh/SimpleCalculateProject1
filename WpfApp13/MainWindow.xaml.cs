using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            // uzgaruvchilar
            string operation = ComboBoxOperation.Text;
            double number1 = Convert.ToDouble(txtBoxInput1.Text);
            double number2 = double.Parse(txtBoxInput2.Text);
            double result = 0;

            // calculator hisoblash
            if (operation == "+")
            {
                result = number1 + number2;
            }
            else if (operation == "-")
            {
                result = number1 - number2;
            }
            else if (operation == "*")
            {
                result = number1 * number2;
            }
            else if (operation == "/")
            {
                if (number2 != 0)
                {
                    result = number1 / number2;
                }
                else
                {
                    MessageBox.Show("0 ga bo'lish mumkin emas", "Xatolik", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
            // natija
            txtBlockResult.Text = result.ToString();
        }
    }
}