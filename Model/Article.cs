namespace ThirdPartyAPIIntegrationRestSharpCRUD.Model
{
    public class Article
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string AuthorUrl { get; set; }

        public string Content { get; set; }

    }
}
