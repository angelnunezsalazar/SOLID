namespace DIP.Controller
{
    class DinnersController
    {
        private readonly DinnerRepository dinnerRepository;

        public DinnersController()
        {
            dinnerRepository = new DinnerRepository();
        }

        public Dinner GetById(int id)
        {
            return dinnerRepository.GetById(id);
        }

    }
}
