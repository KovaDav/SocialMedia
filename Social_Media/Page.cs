namespace Social_Media;

public class Page
{
    public string Title { get; init; }
    public string Description { get; init; }
    public Guid Id { get; init; }
    public HashSet<Post> Posts { get; private set; }

    public Page(string title, string description)
    {
        Title = title;
        Description = description;
        Posts = new HashSet<Post>();
    }

    public void AddPost(Post post)
    {
        Posts.Add(post);
    }

    public IEnumerable<Comment> ListOfModeratedComments(string PostTitle)
    {
        List<Comment> result = new List<Comment>();
        var post = Posts.First(post => post.Title == PostTitle);
        foreach (var comment in post.Comments)
        {
            if (comment.Moderated)
            {
                result.Add(comment);
            }
        }

        return result;
    }
}