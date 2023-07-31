namespace Social_Media;

public class Comment
{
    private string Message { get; set; }
    public Guid Id { get; init; }
    public DateTime DateOfCreation { get; init; }
    private Post PostItBelongsTo { get; init; }
    public bool Moderated { get; private set; }

    public Comment(string message, Post postitbelongsto)
    {
        if (message.Length == 0)
        {
            throw new ArgumentException();
        }
        Message = message;
        PostItBelongsTo = postitbelongsto;
        Id = Guid.NewGuid();
        DateOfCreation = DateTime.Now;
        Moderated = false;
    }

    public void ModerateComment()
    {
        Moderated = true;
    }
    
    public void ModerateComment(string message)
    {
        Message = message;
        Moderated = true;
    }
}