namespace MVCBaba.Models
{
    public class Book2
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public List<string> Authors { get; set; }
        public decimal Price { get; set; }
        public DateTime PublishDate { get; set; }
        

    }
}
