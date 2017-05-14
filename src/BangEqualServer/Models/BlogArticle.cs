namespace BareMetalApi.Models
{
    public class BlogArticle
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Topic { get; set; }
        public string Tags { get; set; }
        public int Views { get; set; }
        public int Shares { get; set; }
        public bool Active { get; set; }
        public string Content { get; set; }
    }  
}