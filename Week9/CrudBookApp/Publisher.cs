namespace CrudBookApp
{
    public class Publisher
    {
        public Publisher(string name)
        {
            this.Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}