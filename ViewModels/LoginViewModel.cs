using AppPractica.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPractica.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        [ObservableProperty]
        private Login login;

        [RelayCommand]
        private void CargarHome()
        {
            if (string.IsNullOrEmpty(login.Usuario) ||
                string.IsNullOrEmpty(login.Contrasena))
            {
                Shell.Current.DisplayAlert("Error", "Porfavor ingrese usuario y/o contraseña", "OK");
                return;
            }
            Preferences.Set("Usuario", login.Usuario);
            Preferences.Set("IsLoggedIn", true);

            Shell.Current.GoToAsync($"//inicio/{nameof(HomeView)}");
        }

        public LoginViewModel()
        {
            login = new Login();
        }
    }
}
