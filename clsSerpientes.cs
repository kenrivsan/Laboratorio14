namespace Laboratorio14
{
    public class clsSerpientes : clsAnimal
    {
        public bool Venenosa { get; set; }
        public decimal Longitud {  get; set; }
        public clsSerpientes()
        {
            Venenosa = false;
            Longitud = 0;
        }

    }
}
