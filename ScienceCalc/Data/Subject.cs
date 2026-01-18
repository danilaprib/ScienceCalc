namespace ScienceCalc.Data
{
    public class Subject
    {
        public int id {  get; set; }
        public string subject_name { get; set; }

        public ICollection<ArticleToSubjectBridge> ArticleToSubjectBridges { get; set; }
    }
}
