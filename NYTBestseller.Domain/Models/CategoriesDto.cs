namespace NYTBestseller.Domain.Models
{
    public class CategoriesDto<T> where T : class
    {
        public string Status { get; set; } = null!;
        public string Copyright { get; set; } = null!;
        public int Num_Results { get; set; }
        public string? Last_Modified { get; set; }
        public T[] Results { get; set; } = null!;
    }
}
