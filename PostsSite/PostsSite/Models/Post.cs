namespace PostsSite.Models
{
    public class Post
    {
        public int id { get; set; }
        public string author { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public DateTime created { get; set; }

    }

}