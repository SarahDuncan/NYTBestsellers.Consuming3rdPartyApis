namespace NYTBestseller.Domain.Models
{
    public class CategoryDto<T> where T : class
    {
        public string Status { get; set; } = null!;
        public string Copyright { get; set; } = null!;
        public int Num_Results { get; set; }
        public string Last_Modified { get; set; } = null!;
        public SpecificCategory Results { get; set; } = null!;
    }
}
