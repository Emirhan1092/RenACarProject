using Core.Entities;

namespace Entities.Concrete
{
    public class CarImages:IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }

        public string ImagePath { get; set; }

        public DateTime ImageDate { get; set; }


    }
}
