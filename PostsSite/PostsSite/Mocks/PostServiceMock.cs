using PostsSite.Models;

namespace PostsSite.Mocks
{
    public class PostServiceMock : IPostService
    {
        public List<Post> Posts { get; set; } = new List<Post>()
        {
            new Post()
            {
                id = 0,
                author= "Darkhan",
                created= DateTime.Now,
                title= "Redbean php tutorial",
                description = "Install redbean php"
            },
        };
    }
}
