namespace Plate.Models
{
    public class Task : ModelBase
    {
        public string name { get; set; }
        public string description { get; set; }
        public int timeToComplete { get; set; }
    }
}
