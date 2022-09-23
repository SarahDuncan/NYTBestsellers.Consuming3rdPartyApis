namespace NYTBestseller.Domain.Models
{
    public class BookReview
    {
        public string Url { get; set; }
        public string Publication_Dt { get; set; }
        public string Byline { get; set; }
        public string Book_Title { get; set; }
        public string Book_Author { get; set; }
        public string Summary { get; set; }
        public string UUID { get; set; }
        public string Uri { get; set; }
        public string[] ISBN13 { get; set; }
    }
}
