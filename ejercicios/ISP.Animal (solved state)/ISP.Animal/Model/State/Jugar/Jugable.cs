namespace ISP.Animal.Model.State.Jugar
{
    interface Jugable
    {
        string GetEstadoAburrido();
        string GetEstadoDivertido();
        void SetEstado(EstadoJugable estadoJugable);
    }
}
