using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Pract2
{
    public partial class ResultWindow : Window
    {
        public ResultWindow(string resultText)
        {
            InitializeComponent();
            
            var resultTextBox = this.FindControl<TextBox>("ResultTextBox");
            if (resultTextBox != null)
            {
                resultTextBox.Text = resultText;
            } 
        }
        
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}