using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ConsumirWebServices
{
    
    public class Result
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public string carrera { get; set; }

        /*public List<Result> getData()
        {
            RestClient client = new RestClient();
            var result = await client.GetRequest<List<Result>>("http://jairbarzola.esy.es/jairwsji.json");
            List<Result> list = new List<Result>();
            return result;
        }




        async static void resquest()
        {
            RestClient client = new RestClient();
            var result = await client.GetRequest<List<Result>>("http://jairbarzola.esy.es/jairwsji.json");

        }*/

    }
}
