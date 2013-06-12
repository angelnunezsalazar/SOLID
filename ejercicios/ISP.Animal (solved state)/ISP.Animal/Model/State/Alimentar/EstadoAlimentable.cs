namespace ISP.Animal.Model.State.Alimentar
{
    interface EstadoAlimentable
    {
        string GetEstadoPara(Alimentable alimentable);
        void Alimentar(Alimentable alimentable);
    }
}
