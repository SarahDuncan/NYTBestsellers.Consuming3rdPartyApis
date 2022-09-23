namespace NYTBestseller.Domain.Models
{
    public class SpecificCategory
    {
        public string List_Name { get; set; } = null!;
        public string List_Name_Encoded { get; set; } = null!;
        public string Bestsellers_date { get; set; } = null!;
        public string Published_Date { get; set; } = null!;
        public string Published_Date_Description { get; set; } = null!;
        public string Next_Published_Date { get; set; } = null!;
        public string Previous_Published_Date { get; set; } = null!;
        public string Display_Name { get; set; } = null!;
        public int Normal_List_Ends_At { get; set; }
        public string Updated { get; set; } = null!;
        public Book[] Books { get; set; } = null!;
        public Type[] Corrections { get; set; } = null!;
    }
}
