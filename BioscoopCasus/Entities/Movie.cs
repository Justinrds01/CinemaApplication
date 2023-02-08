using Newtonsoft.Json;

namespace BioscoopCasus.Entities
{
    public class Movie
    {
        [JsonProperty]
        private string Title;
        [JsonProperty]
        private List<MovieScreening> MovieScreenings;

        public Movie(string title)
        {
            Title = title;
            MovieScreenings = new();
        }

        public void AddScreening(MovieScreening screening)
        {
            MovieScreenings.Add(screening);
        }

        public override string ToString()
        {
            return "Title: " + Title;
        }

    }
}
