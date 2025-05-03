namespace jurnal10
{
    public class Movie
    {
        public string title { get; set; }
        public string Director { get; set; }
        public List<string> Star { get; set; }
        public string Description { get; set; }
        public Movie(string title, string director, List<string> star, string description) { 
           this.title = title;
           this.Director = director;
           this.Star = star;
           this.Description = description;
        }
    }
}
