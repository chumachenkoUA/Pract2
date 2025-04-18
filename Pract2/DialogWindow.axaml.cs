using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Pract2
{
    public partial class DialogWindow : Window
    {
        private readonly MainWindow _mainWindow;

        public DialogWindow(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
            InitializeComponent();
        }

        private void ProcessButton_Click(object sender, RoutedEventArgs e)
        {
            string text = InputTextBox.Text ?? string.Empty;
            
           // Надіслати до головного вікна для обробки
            _mainWindow.ProcessText(text);
            
        }
        
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}