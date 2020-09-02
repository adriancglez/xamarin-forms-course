using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace B_XamarinViewsApp {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e) {
            DisplayAlert("Mensaje", "Diste Click!", "ok");
        }
    }
}
