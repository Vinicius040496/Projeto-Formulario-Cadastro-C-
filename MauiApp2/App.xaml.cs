using Microsoft.Maui;

namespace MauiApp2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
        protected override Window CreateWindow(IActivationState actitivationState)
        {
            var Window = base.CreateWindow(actitivationState);
            Window.Width = 400;
            Window.Height = 600;
            return Window;
        }
    }
  
}
