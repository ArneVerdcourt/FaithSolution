namespace Faith.API.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public int JongereId { get; set; }
        public DateTime TimeStamp { get; set; }
        public string ImageURL { get; set; }
    }
}
