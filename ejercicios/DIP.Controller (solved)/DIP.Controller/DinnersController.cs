namespace DIP.Controller
{
    class DinnersController
    {
        private readonly IDinnerRepository dinnerRepository;

        public DinnersController(IDinnerRepository dinnerRepository)
        {
            this.dinnerRepository = dinnerRepository;
        }

        public Dinner GetById(int id)
        {
            return dinnerRepository.GetById(id);
        }

    }
}
