using AAMRecetteAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class AAMRecetteAPIContext : DbContext
    {
        public AAMRecetteAPIContext(DbContextOptions<AAMRecetteAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          => optionsBuilder.UseNpgsql("Host=localhost:5433;Database=api_recipe_db;Username=user_demo;Password=a123456A!");

        //public class Category
        //{
        //    public int Id { get; set; }
        //    public string? Name { get; set; }
        //    public string? Photo_url { get; set; }
        //}

        //public class Recipe
        //{
        //    public int RecipeId { get; set; }
        //    public string? Title { get; set; }
        //    public string? Photo_url { get; set; }
        //    public string? PhotosArray { get; set; }
        //    public TimeOnly Time { get; set; }
        //    public string? Ingredients { get; set; }
        //    public string? Description { get; set; }
        //    public int CategoryId { get; set; }
        //    public Category? Category { get; set; }
        //}
        //public class Ingredient
        //{
        //    public int IngredientId { get; set; }
        //    public string? Name { get; set; }
        //    public string? Photo_url { get; set; }
        //}
    }
}
