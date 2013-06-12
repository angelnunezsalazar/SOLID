namespace ISP.Animal.Model.State.Jugar
{
    class Aburrido : EstadoJugable
    {
        public string GetEstadoPara(Jugable jugable)
        {
            return jugable.GetEstadoAburrido();
        }

        public void Jugar(Jugable jugable)
        {
            jugable.SetEstado(new Divertido());
        }
    }
}
