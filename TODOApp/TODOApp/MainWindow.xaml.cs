using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TODOApp
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

        private void AddTODOButton_Click(object sender, RoutedEventArgs e)
        {
            string todoText = TODOInput.Text;
            if(!string.IsNullOrEmpty(todoText) )
            {
                TextBlock todoTextBlock = new TextBlock
                {
                    Text = todoText,
                    Foreground = new SolidColorBrush(Colors.White),
                    Margin = new Thickness(10)
                };

                TODOList.Children.Add(todoTextBlock);
                TODOInput.Clear();
            }
        }
    }
}
