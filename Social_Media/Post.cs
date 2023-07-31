namespace Social_Media;

public class Post
{
    public string Title { get; init; }
    public string Message { get; init; }
    public Guid Id { get; init; }
    public DateTime DateOfCreation { get; init; }
    public Page PageItBelongsTo { get; init; }
    public List<Comment> Comments { get; private set; }
    public TypeOfPost Type { get; private set; }

    public Post(string title, string message, Page pageitbelongsto, TypeOfPost type)
    {
        if (message.Length == 0 || title.Length == 0)
        {
            throw new ArgumentException();
        }

        Title = title;
        Message = message;
        Id = Guid.NewGuid();
        DateOfCreation = DateTime.Now;
        PageItBelongsTo = pageitbelongsto;
        Type = type;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }
}