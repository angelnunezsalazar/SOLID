using System;
using ISP.Animal.Model.State;
using ISP.Animal.Model.State.Alimentar;

namespace ISP.Animal.Model
{
    class Serpiente : Animal, Alimentable
    {
        private EstadoAlimentable estado = new Hambriento();

        public void Alimentar()
        {
            estado.Alimentar(this);
        }

        public string GetEstado()
        {
            return estado.GetEstadoPara(this);
        }

        public string GetEstadoAlimentado()
        {
            return "no " + GetEstadoHambriento();
        }

        public string GetEstadoHambriento()
        {
            return "quiero una rata";
        }

        public void SetEstado(EstadoAlimentable estadoAlimentable)
        {
            this.estado = estadoAlimentable;
        }
    }
}
