﻿
namespace _5M05mobWeterynarz
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
        }
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = new Window();
            window.MaximumHeight = 800;
            window.MinimumHeight = 800;
            window.MaximumWidth = 400;
            window.MinimumWidth = 400;
            window.Title = "wykonał: mm";
            window.Page = new AppShell();
            return window;
        }
    }
}