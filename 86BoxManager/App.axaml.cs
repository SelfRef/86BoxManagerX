using _86boxManager.ViewModels;
using _86boxManager.Views;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

namespace _86boxManager
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
                desktop.MainWindow = new frmMain
                {
                    DataContext = new MainModel()
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}