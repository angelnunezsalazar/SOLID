using System;

namespace ISP.Animal.Model.State.Alimentar
{
    class Alimentado : EstadoAlimentable
    {
        public string GetEstadoPara(Alimentable alimentable)
        {
            return alimentable.GetEstadoAlimentado();
        }

        public void Alimentar(Alimentable alimentable)
        {
        }
    }
}
