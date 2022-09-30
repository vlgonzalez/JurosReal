using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JurosReal.Models;


namespace JurosReal.Controllers
{
    public class TaxaController : Controller
    {
        public IActionResult Index( )
             {
               return View();
             }
        
        public async Task<ActionResult> Buscar(Investimento investe )
        {
            
            using HttpClient client = new()
            {
                BaseAddress = new Uri("https://brasilapi.com.br/api/taxas/v1/{sigla}")
            };
            // Get the user information.
            TaxaView? taxa = await client.GetFromJsonAsync<TaxaView>($"{investe.NomeTaxa}");
            var taxaIpca = await client.GetFromJsonAsync<TaxaView>("IPCA");

            if(investe.Meses <= 6)
            {
            investe.Ir = 0.775;
             
             } else if (investe.Meses <= 12)
             {
                investe.Ir = 0.80;

             }else if (investe.Meses <= 24)
             {
                investe.Ir = 0.825;
             }else
             {
                investe.Ir = 0.85;
             }
            
            investe.Rentabilidade =((((taxa.Valor/100)/12)*investe.Meses) * investe.ValorInvestido);
            investe.RetornoBruto =   investe.Rentabilidade + investe.ValorInvestido;
            investe.RetornoLiquido = investe.Rentabilidade * investe.Ir + investe.ValorInvestido;
            investe.RetornoReal = investe.RetornoLiquido -(((taxaIpca.Valor/100)/12)*investe.Meses);

            return View(investe);
                 
        }
 

        





        //public ActionResult Buscar(string sigla)
        //{

            
               
            // StreamReader r = new StreamReader($"https://brasilapi.com.br/api/taxas/v1/selic");
            // string jsonString = r.ReadToEnd();
            // TaxaView selic = JsonConvert.DeserializeObject<TaxaView>(jsonString); 

            // StreamReader i = new StreamReader($"https://brasilapi.com.br/api/taxas/v1/IPCA");
            // string jsonStringi = i.ReadToEnd();
            // TaxaView Ipca = JsonConvert.DeserializeObject<TaxaView>(jsonStringi); 

            // StreamReader c = new StreamReader("https://brasilapi.com.br/api/taxas/v1/cdi");
            // string jsonStringc = c.ReadToEnd();
            // TaxaView CDI = JsonConvert.DeserializeObject<TaxaView>(jsonStringc);

           // return View(CDI);
        //}
    }    
    
    }

    
