namespace Laboratorio14
{
    public class clsSerpientes : clsAnimal
    {
        public string Venenosa { get; set; }
        public decimal Longitud {  get; set; }
        public clsSerpientes()
        {
            Venenosa = string.Empty;
            Longitud = 0;
        }

    }
}
