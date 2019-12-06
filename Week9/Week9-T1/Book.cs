namespace Week9_T1
{
    public class Book
    {
        public Book(string title, int publisherId, int year, decimal price)
        {
            this.Title = title;
            this.PublisherId = publisherId;
            this.Year = year;
            this.Price = price;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public int PublisherId { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
    }
}