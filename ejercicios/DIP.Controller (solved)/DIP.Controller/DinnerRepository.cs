namespace DIP.Controller
{
    class DinnerRepository : IDinnerRepository
    {
        public Dinner GetById(int id)
        {
            return new Dinner() { Name = "cumpleaños"};
        }
    }
}
