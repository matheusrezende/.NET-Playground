namespace EventApi.Models
{
    public class Event
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long StartDate { get; set; }
        public long EndDate { get; set; }
    }
}