using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JurosReal.Models
{
    public class Investimento :TaxaView
    {
        [DataType(DataType.Currency)]
       public double ValorInvestido { get; set; }

       public double Meses { get; set; }
        [DataType(DataType.Currency)]
       public double RetornoBruto { get; set; }
        [DataType(DataType.Currency)]
      public double RetornoLiquido { get; set; }
      [DataType(DataType.Currency)]
      public double RetornoReal { get; set; }
        [DataType(DataType.Currency)]
      public double Rentabilidade { get; set; }

      public double Ir { get; set; }
    }
}