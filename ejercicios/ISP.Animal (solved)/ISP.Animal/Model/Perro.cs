namespace ISP.Animal.Model
{
    public class Perro : Mascota
    {
        private bool alimentado;
        private bool acariciado;
        public void Alimentar()
        {
            alimentado = true;
        }

        public void Acariciar()
        {
            acariciado = true;
        }

        public string GetEstado()
        {
            string estado = string.Empty;
            if (alimentado) estado = "no quiero un hueso";
            if (!alimentado) estado = "quiero un hueso";
            if (!acariciado) estado += " y quiero jugar";
            return estado;
        }
    }
}
