using System;
using ISP.Animal.Model.State;
using ISP.Animal.Model.State.Alimentar;
using ISP.Animal.Model.State.Jugar;

namespace ISP.Animal.Model
{
    class Perro : Mascota, Alimentable, Jugable
    {
        private EstadoAlimentable estadoAlimentable = new Hambriento();
        private EstadoJugable estadoJugable = new Aburrido();

        public void Alimentar()
        {
            estadoAlimentable.Alimentar(this);
        }

        public void Acariciar()
        {
            estadoJugable.Jugar(this);
        }

        public string GetEstado()
        {
            return estadoAlimentable.GetEstadoPara(this) + estadoJugable.GetEstadoPara(this);
        }

        public string GetEstadoAlimentado()
        {
            return "no " + GetEstadoHambriento();
        }

        public string GetEstadoHambriento()
        {
            return "quiero un hueso";
        }

        public void SetEstado(EstadoAlimentable estadoAlimentable)
        {
            this.estadoAlimentable = estadoAlimentable;
        }

        public string GetEstadoAburrido()
        {
            return " y quiero jugar";
        }

        public string GetEstadoDivertido()
        {
            return "";
        }

        public void SetEstado(EstadoJugable estadoJugable)
        {
            this.estadoJugable = estadoJugable;
        }
    }
}
