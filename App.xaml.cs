﻿using BLOGSOCIALUDLA.Views;

namespace BLOGSOCIALUDLA
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //var navPage= new NavigationPage(new LoginView());
            var navPage = new NavigationPage(new InicioSesion());
            navPage.Background = Colors.DarkRed;
            navPage.BarTextColor = Colors.DarkRed;

            //MainPage = navPage;
            MainPage = new AppShell();
            //MainPage = new InicioSesion();

            //Registro Cuenta 
            //  MainPage = new PaginaPrincipal();

            //RegistroCuenta
            //MainPage = new RegistroUsuario();

        }
    }
}
