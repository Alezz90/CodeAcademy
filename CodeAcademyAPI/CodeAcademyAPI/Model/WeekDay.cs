namespace CodeAcademyAPI.Model
{
    public class WeekDay
    {
        public int ID { get; set; }
        public string Title { get; set; }

        public ICollection<Todo> Todo { get; set; }
    }
}
