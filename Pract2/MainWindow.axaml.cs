using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using System.Text;

namespace Pract2
{
    public partial class MainWindow : Window
    {
        private DialogWindow? _dialogWindow;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenDialogButton_Click(object sender, RoutedEventArgs e)
        {
            // Відкрити діалогове вікно немодально
            _dialogWindow = new DialogWindow(this);
            _dialogWindow.Show();
        }

        public void ProcessText(string text)
        {
            
                int asciiCode = int.Parse(CodeTextBox.Text);

                var lines = text.Split("\n");
                var resultBuilder = new StringBuilder();
                resultBuilder.AppendLine($"Слова, в яких 3-я літера відповідає ASCII коду {asciiCode}:");
                resultBuilder.AppendLine();

                bool foundAny = false;
                foreach (var line in lines)
                {
                    var words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    foreach (var word in words)
                    {
                        if (word.Length >= 3 && word[2] == (char)asciiCode)
                        {
                            foundAny = true;
                            resultBuilder.AppendLine($"Рядок: \"{line}\"");
                            resultBuilder.AppendLine($"   • {word} (3-тя літера: '{word[2]}'");
                            resultBuilder.AppendLine();
                        }
                    }
                }

                ShowResult(foundAny 
                    ? resultBuilder.ToString() 
                    : $"Не знайдено жодного слова, де 3-я літера має ASCII код {asciiCode}.");
            
        }

        private void ShowResult(string resultText)
        {
            // Створити та показати третю форму з результатами замість відображення в головному вікні
            var resultWindow = new ResultWindow(resultText);
            resultWindow.Show();
        }
        
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}