using DemoBindableProperty.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoBindableProperty {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();

            FlagViewModel viewModel = new FlagViewModel();
            this.BindingContext = viewModel;
        }
    }
}
