using System;

namespace ISP.Animal.Model
{
    public class Serpiente : Animal
    {
        private bool alimentada;
        public void Alimentar()
        {
            alimentada = true;
        }

        public string GetEstado()
        {
            string estado = "quiero una rata";
            if (alimentada) estado = "no " + estado;
            return estado;
        }
    }
}
