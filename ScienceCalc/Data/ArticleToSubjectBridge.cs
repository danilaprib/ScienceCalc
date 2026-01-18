namespace ScienceCalc.Data
{
    public class ArticleToSubjectBridge
    {
        public int article_id { get; set; }
        public Article article { get; set; }

        public int subject_id { get; set; }
        public Subject subject { get; set; }
    }
}
