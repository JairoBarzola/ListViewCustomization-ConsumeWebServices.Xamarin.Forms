using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumirWebServices.ViewModel
{
    
    public class ResultViewModel
    {
        public List<Result> ListaJson { get; set; }

        public ResultViewModel()
        {
            //ListaJson = new Result().getData();
        }

    }
}
