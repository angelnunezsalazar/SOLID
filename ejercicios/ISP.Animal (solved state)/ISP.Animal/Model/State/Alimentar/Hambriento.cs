using System;

namespace ISP.Animal.Model.State.Alimentar
{
    class Hambriento : EstadoAlimentable
    {
        public string GetEstadoPara(Alimentable alimentable)
        {
            return alimentable.GetEstadoHambriento();
        }

        public void Alimentar(Alimentable alimentable)
        {
            alimentable.SetEstado(new Alimentado());
        }
    }
}
