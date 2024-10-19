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

namespace HelloButton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly TextBox _myTextBox;

        public MainWindow()
        {
            InitializeComponent();

            /*
             * Все элементы с помощью метода LayoutGrid.Children.Add размещаются в центре формы.
             * Они не идут в гриде один за другим, они именно что сваливаются в центр
             * и с помощью myTextBox.Margin ниже - я вытаскиваю TextBox из под Button.
             */
            _myTextBox = new TextBox();
            _myTextBox.Width = 200;
            _myTextBox.Height = 30;
            _myTextBox.Margin = _myTextBox.Margin with { Bottom = 65 };
            LayoutGrid.Children.Add(_myTextBox);

            Button myButton = new Button();
            myButton.Width = 200;
            myButton.Height = 30;
            myButton.Content = "Кнопка";
            myButton.Click += Button_Click;
            LayoutGrid.Children.Add(myButton);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string text = _myTextBox.Text;
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("TextBox Empty");
            }
            else
            {
                MessageBox.Show(text);
            }
        }
    }
}