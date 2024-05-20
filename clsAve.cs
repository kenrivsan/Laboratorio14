using Microsoft.AspNetCore.Components.Web;

namespace Laboratorio14
{
    public class clsAve : clsAnimal
    {
        public bool Vuela { get; set; } 
        public string Periodo {  get; set; }
        public clsAve()
        {
            Vuela = true;
            Periodo = string.Empty;
        }
    }
}
