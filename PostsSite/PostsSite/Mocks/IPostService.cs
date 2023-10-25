using PostsSite.Models;

namespace PostsSite.Mocks
{
    /// <summary>
    /// Interface 
    /// </summary>
    public interface IPostService
    {
        public List<Post> Posts { get; set; } 
    }

}