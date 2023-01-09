using DevOpsnb.Models;
namespace DevOpsnb.Repository
{
    public interface IPostRepository
    {
        List<PostViewModel> GetPosts();
    }
}
