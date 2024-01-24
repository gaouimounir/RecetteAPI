namespace AAMRecetteAPI.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public string? Title { get; set; }
        public string? Photo_url { get; set; }
        public List<string>? PhotosArray { get; set; }
        public int Time { get; set; }
        public string? Ingredients { get; set; }
        public string? Description { get; set; }
        public int CategoryId { get; set; }  
        public Category? Category { get; set; }

    }
}
