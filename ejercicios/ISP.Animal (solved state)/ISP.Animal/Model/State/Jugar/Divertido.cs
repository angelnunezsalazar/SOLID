namespace ISP.Animal.Model.State.Jugar
{
    class Divertido : EstadoJugable
    {
        public string GetEstadoPara(Jugable jugable)
        {
            return jugable.GetEstadoDivertido();
        }

        public void Jugar(Jugable jugable)
        {
        }
    }
}
