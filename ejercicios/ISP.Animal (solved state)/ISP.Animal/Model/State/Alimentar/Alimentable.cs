namespace ISP.Animal.Model.State.Alimentar
{
    interface Alimentable
    {
        string GetEstadoAlimentado();
        string GetEstadoHambriento();
        void SetEstado(EstadoAlimentable estadoAlimentable);
    }
}
