using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ConsumirWebServices
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        protected  override void OnAppearing()
        {
            base.OnAppearing();
            Device.BeginInvokeOnMainThread(async () => {
                RestClient client = new RestClient();
                var result = await client.GetRequest<List<Result>>("http://jairbarzola.esy.es/jairwsji.json");
                if (default(List<Result>) != result)
                {           
                    listView.ItemsSource = result;
                }
            });

        }
    }
}
