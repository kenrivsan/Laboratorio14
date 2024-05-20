namespace Laboratorio14
{
    public class clsAnimal
    {
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Alimentacion { get; set; }
        public int AniosVida { get; set; }
        public clsAnimal()
        {
            Nombre = string.Empty; 
            Especie = string.Empty; 
            Alimentacion = string.Empty;
            AniosVida = 0;
        }
    }
}
