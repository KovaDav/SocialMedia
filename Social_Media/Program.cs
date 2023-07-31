using Social_Media;

Page page = new Page("title", "description");
Post post = new Post("titleofpost","messageofpost",page,TypeOfPost.Regular);
Comment comment1 = new Comment("messgeofcomment1", post);
Comment comment2 = new Comment("messgeofcomment2", post);

post.AddComment(comment1);
post.AddComment(comment2);


comment1.ModerateComment();



page.AddPost(post);


Console.WriteLine(page.ListOfModeratedComments("titleofpost"));