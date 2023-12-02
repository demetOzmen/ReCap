using Core.Entities;

namespace Entities.Concrete
{
    public class Order:IEntity
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public string CustomerCity { get; set; }
    }
}
