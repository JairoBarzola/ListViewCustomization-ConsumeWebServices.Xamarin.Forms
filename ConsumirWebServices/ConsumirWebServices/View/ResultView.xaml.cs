using ConsumirWebServices.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConsumirWebServices.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResultView : ContentPage
    {
        ResultViewModel vm;
        public ResultView()
        {
            vm = new ResultViewModel();
            BindingContext = vm;
            InitializeComponent();
        }
    }
}