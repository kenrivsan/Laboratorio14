using Microsoft.AspNetCore.Components.Web;

namespace Laboratorio14
{
    public class clsAve : clsAnimal
    {
        public string Vuela { get; set; } 
        public string Periodo {  get; set; }
        public clsAve()
        {
            Vuela = string.Empty;
            Periodo = string.Empty;
        }
    }
}
