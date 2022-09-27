using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JurosReal.Models;
using RestSharp;

namespace JurosReal.Controllers
{
    public class TaxaController : Controller
    {
        public IActionResult Index( string nome)
        {
            var client = new RestClient($"https://brasilapi.com.br/api/taxas/v1/{nome}");
            RestRequest request = new RestRequest("nome", Method.Get);
            var response = client.Execute(request);

            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            return View(response.Content);
            else
            {
                return View(response.ErrorMessage);
            }
        }
    }
}