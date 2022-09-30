using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JurosReal.Models
{
    public class Investimento :TaxaView
    {
       public double ValorInvestido { get; set; }

       public double Meses { get; set; }

       public double RetornoBruto { get; set; }

      public double RetornoLiquido { get; set; }
      public double RetornoReal { get; set; }

      public double Rentabilidade { get; set; }

      public double Ir { get; set; }
    }
}