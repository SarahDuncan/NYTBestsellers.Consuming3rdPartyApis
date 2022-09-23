namespace NYTBestseller.Domain.Models
{
    public class GeneralCategory
    {
        public string List_Name { get; set; } = null!;
        public string Display_Name { get; set; } = null!;
        public string List_Name_Encoded { get; set; } = null!;
        public string Oldest_Published_Date { get; set; } = null!;
        public string Newest_Published_Date { get; set; } = null!;
        public string Updated { get; set; } = null!;
    }
}
