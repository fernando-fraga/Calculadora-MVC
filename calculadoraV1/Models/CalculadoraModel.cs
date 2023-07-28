using Microsoft.AspNetCore.Mvc.Rendering;

namespace calculadoraV1.Models
{
    public class CalculadoraModel
    {
        public double Valor1 { get;set;}
        public double Valor2 { get;set;}
       
        public string Operador { get;set;}
        public double Resultado { get;set;}

      
    }
}
