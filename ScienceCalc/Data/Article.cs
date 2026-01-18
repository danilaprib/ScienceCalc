namespace ScienceCalc.Data
{
    public class Article
    {
        public int id { get; set; }
        public string content { get; set; }
        public string title { get; set; }

        public DateTime created_at { get; set; }

        public ICollection<ArticleToSubjectBridge> ArticleToSubjectBridges { get; set; }

    }
}
