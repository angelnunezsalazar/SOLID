namespace ISP.Animal.Model.State.Jugar
{
    interface EstadoJugable
    {
        string GetEstadoPara(Jugable jugable);
        void Jugar(Jugable jugable);
    }
}
