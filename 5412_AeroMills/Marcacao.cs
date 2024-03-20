using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Marcacao
    {
        public string Id;
        public string Price;
        public string StartDate;
        public string EndDate;

        public Marcacao(string id, string dataInicio, string dataFim)
        {
            Id = id;
            StartDate = dataInicio;
            EndDate = dataFim;
        }

        public Marcacao(string id, string price, string dataInicio, string dataFim)
        {
            Id = id;
            Price = price;
            StartDate = dataInicio;
            EndDate = dataFim;
        }

        public override string ToString()
        {
            return base.ToString() + "Id: " + Id.ToString() + "DataInicio: " + StartDate + "DataFim: " + EndDate;
        }
    }
}
