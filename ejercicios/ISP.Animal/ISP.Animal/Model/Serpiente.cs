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

        public void Acariciar()
        {
            // ignore - I'm not grooming a freaking rattlesnake
            throw new NotImplementedException("No voy a acariciar a una serpiente");
        }

        public string GetEstado()
        {
            string estado = "quiero una rata";
            if (alimentada) estado = "no " + estado;
            return estado;
        }
    }
}
