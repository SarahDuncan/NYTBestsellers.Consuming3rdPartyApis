namespace NYTBestseller.Domain.Models
{
    public class Book
    {
        public int Rank { get; set; }
        public int Rank_Last_Week { get; set; }
        public int Weeks_On_List { get; set; }
        public int Asterisk { get; set; }
        public int Dagger { get; set; }
        public string Primary_ISBN10 { get; set; } = null!;
        public string Primary_ISBN13 { get; set; } = null!;
        public string Publisher { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Price { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Author { get; set; } = null!;
        public string Contributor { get; set; } = null!;
        public string Contributor_Note { get; set; } = null!;
        public string Book_Image { get; set; } = null!;
        public int Book_Image_Width { get; set; }
        public int Book_Image_Height { get; set; }
        public string Amazon_Product_Url { get; set; } = null!;
        public string Age_Group { get; set; } = null!;
        public string Book_Review_Link { get; set; } = null!;
        public string First_Chapter_Link { get; set; } = null!;
        public string Sunday_Review_Link { get; set; } = null!;
        public string Article_Chapter_Link { get; set; } = null!;
        public ISBN[] ISBNs { get; set; } = null!;
        public BuyLink[] Buy_Links { get; set; } = null!;
        public string Book_Uri { get; set; } = null!;
    }
}
