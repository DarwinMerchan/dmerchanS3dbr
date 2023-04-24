using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dmerchanS2dbr
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Operaciones : ContentPage
    {
        public Operaciones()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NOTA1.Text) && !string.IsNullOrEmpty(NOTA2.Text))
            {
                var Nota1 = double.Parse(NOTA1.Text) * 0.3;
                var Nota2 = double.Parse(NOTA2.Text) * 0.2;
                var Nota3 = double.Parse(NOTA3.Text) * 0.3;
                var Nota4 = double.Parse(NOTA4.Text) * 0.2;

                var resultado = Nota1 + Nota2 + Nota3 + Nota4;

                Resultado.Text = resultado.ToString();

                string mensaje = "";

                if (resultado >= 7)
                {
                    mensaje = "Aprobado";
                }

                else if (resultado >= 5 && resultado <= 6.9)
                {
                    mensaje = "Complementario";
                }
                else
                {
                    mensaje = "Reprobado";
                }
                    DisplayAlert("Resultado", mensaje, "ok");
                }
            }
        }
    
    }




                 
       

       
   