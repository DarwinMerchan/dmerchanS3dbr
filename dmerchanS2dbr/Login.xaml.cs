﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dmerchanS2dbr
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;
            if (usuario == "estudiante2023" && contrasena == "uisrael2023")
            {
                Navigation.PushAsync(new Operaciones());
            }
            else
            {
                //bota la alerta y se limpia el cuadro 
                DisplayAlert("ALERTA", "Usuario/Contraseña Incorrectos", "Cerrar");
                txtUsuario.Text = "";
                txtContrasena.Text = "";
            }
        }

        private void btnRegistrar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Registro());
        }

        private void txtdato_TextChanged(object sender, TextChangedEventArgs e)
        {
            //try
            //{
              //  double numero = Convert.ToDouble(txtdato.Text);
                //if (numero < 1 && numero > 10)
                //{
                  //  DisplayAlert("Mensaje", "El rango permitido es 1-10", "Cerrar");
                    //txtdato.Text = "";
                //}
            //} 
            //catch (Exception ex)
            //{

              //  DisplayAlert("ERROR", ex.Message, "Cerrar");
            //}
            
            
        }
    }
}