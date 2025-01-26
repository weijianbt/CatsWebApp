namespace CatsWebApp.Models
{
    public class Cat
    {
        public Cat()
        {
            
        }

        public int Id { get; set; }

        public string? Name { get; set; }

        public int Age { get; set; }

        public string? Species { get; set; }

        public string? ImagePath { get; set; }
    }
}
