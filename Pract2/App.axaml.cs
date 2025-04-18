using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

namespace Pract2
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                var mainWindow = new MainWindow();
                
                // Create dialog window with reference to main window
                var dialogWindow = new DialogWindow(mainWindow);
                
                // Set main window as the application's main window
                desktop.MainWindow = mainWindow;
                
                mainWindow.Show();
                dialogWindow.Show();
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}