namespace FoodRecipe.Data;

using FoodRecipe.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

public class FoodDbContext : DbContext
{
    public DbSet<Food> Foods { get; set; } = null!;
    public DbSet<Recipe> Recipes { get; set; } = null!;

    public FoodDbContext(DbContextOptions<FoodDbContext> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=LAKICI53;Database=Food;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        base.OnConfiguring(optionsBuilder);
        optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Food>(entity =>
        {
            entity.HasKey(f => f.Id);
            entity.Property(f => f.FoodName).IsRequired().HasMaxLength(100);
            entity.Property(f => f.FoodVariety).HasMaxLength(50);

            entity.HasMany(f => f.Recipes) 
                  .WithOne(r => r.Food)    
                  .HasForeignKey(r => r.FoodId)
                  .OnDelete(DeleteBehavior.Cascade); 
        });

        modelBuilder.Entity<Recipe>(entity =>
        {
            entity.HasKey(r => r.Id);
            entity.Property(r => r.Description).IsRequired().HasMaxLength(500);
        });
        modelBuilder.Entity<Food>(b =>
        {
            b.Property<Guid>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("uniqueidentifier");

            b.Property<DateTime>("CreatedDate")
                .HasColumnType("datetime2");

            b.Property<DateTime?>("ModifiedDate")
                .HasColumnType("datetime2");

            b.Property<bool>("IsDeleted")
                .HasColumnType("bit");

            b.Property<string>("FoodName")
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            b.Property<string>("FoodVariety")
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            b.HasKey("Id");

            b.ToTable("Foods");
        });
        modelBuilder.Entity<Recipe>(b =>
        {
            b.Property<Guid>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("uniqueidentifier");

            b.Property<DateTime>("CreatedDate")
                .HasColumnType("datetime2");

            b.Property<DateTime?>("ModifiedDate")
                .HasColumnType("datetime2");

            b.Property<bool>("IsDeleted")
                .HasColumnType("bit");

            b.Property<string>("Description")
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            b.Property<Guid>("FoodId")
                .HasColumnType("uniqueidentifier");

            b.HasKey("Id");

            b.HasIndex("FoodId");

            b.ToTable("Recipes");

            b.HasOne<Food>()
                .WithMany(f => f.Recipes)
                .HasForeignKey("FoodId")
                .OnDelete(DeleteBehavior.Cascade);
        });
        var pizzaFoodId = Guid.NewGuid();
        var burgerFoodId = Guid.NewGuid();
        var sushiFoodId = Guid.NewGuid();
        var pastaFoodId = Guid.NewGuid();
        var tacosFoodId = Guid.NewGuid();
        var padThaiFoodId = Guid.NewGuid();
        var chickenCurryFoodId = Guid.NewGuid();
        var falafelFoodId = Guid.NewGuid();
        var chocolateCakeFoodId = Guid.NewGuid();
        var applePieFoodId = Guid.NewGuid();


        modelBuilder.Entity<Food>().HasData(
            new Food { Id = pizzaFoodId, FoodName = "Pizza", FoodVariety = "Italian" },
            new Food { Id = burgerFoodId, FoodName = "Burger", FoodVariety = "American" },
            new Food { Id = sushiFoodId, FoodName = "Sushi", FoodVariety = "Japanese" },
            new Food { Id = pastaFoodId, FoodName = "Pasta", FoodVariety = "Italian" },
            new Food { Id = tacosFoodId, FoodName = "Tacos", FoodVariety = "Mexican" },
            new Food { Id = padThaiFoodId, FoodName = "Pad Thai", FoodVariety = "Thai" },
            new Food { Id = chickenCurryFoodId, FoodName = "Chicken Curry", FoodVariety = "Indian" },
            new Food { Id = falafelFoodId, FoodName = "Falafel", FoodVariety = "Middle Eastern" },
            new Food { Id = chocolateCakeFoodId, FoodName = "Chocolate Cake", FoodVariety = "Dessert" },
            new Food { Id = applePieFoodId, FoodName = "Apple Pie", FoodVariety = "Dessert" }

        );

        modelBuilder.Entity<Recipe>().HasData(
            new Recipe { Id = Guid.NewGuid(), Description = "Prepare the dough and add toppings.", FoodId = pizzaFoodId },
            new Recipe { Id = Guid.NewGuid(), Description = "Bake in a preheated oven at 220°C for 15 minutes.", FoodId = pizzaFoodId },
            new Recipe { Id = Guid.NewGuid(), Description = "Grill the beef patty with salt and pepper.", FoodId = burgerFoodId },
            new Recipe { Id = Guid.NewGuid(), Description = "Assemble the burger with lettuce, tomato, and cheese.", FoodId = burgerFoodId },
            new Recipe { Id = Guid.NewGuid(), Description = "Prepare sushi rice with vinegar and sugar.", FoodId = sushiFoodId },
            new Recipe { Id = Guid.NewGuid(), Description = "Roll the rice with fish and seaweed using a bamboo mat.", FoodId = sushiFoodId },
            new Recipe { Id = Guid.NewGuid(), Description = "Boil pasta in salted water for 10 minutes.", FoodId = pastaFoodId },
            new Recipe { Id = Guid.NewGuid(), Description = "Prepare the sauce with tomatoes and garlic.", FoodId = pastaFoodId },
            new Recipe { Id = Guid.NewGuid(), Description = "Cook minced meat with taco seasoning.", FoodId = tacosFoodId },
            new Recipe { Id = Guid.NewGuid(), Description = "Fill tortillas with meat, lettuce, and cheese.", FoodId = tacosFoodId },
            new Recipe { Id = Guid.NewGuid(), Description = "Cook rice noodles until tender.", FoodId = padThaiFoodId },
            new Recipe { Id = Guid.NewGuid(), Description = "Stir-fry with shrimp, egg, and Pad Thai sauce.", FoodId = padThaiFoodId },
            new Recipe { Id = Guid.NewGuid(), Description = "Cook chicken pieces with curry spices.", FoodId = chickenCurryFoodId },
            new Recipe { Id = Guid.NewGuid(), Description = "Add coconut milk and simmer for 20 minutes.", FoodId = chickenCurryFoodId },
            new Recipe { Id = Guid.NewGuid(), Description = "Blend chickpeas with herbs and spices.", FoodId = falafelFoodId },
            new Recipe { Id = Guid.NewGuid(), Description = "Form balls and deep fry until crispy.", FoodId = falafelFoodId },
            new Recipe { Id = Guid.NewGuid(), Description = "Mix cocoa, sugar, and flour into a batter.", FoodId = chocolateCakeFoodId },
            new Recipe { Id = Guid.NewGuid(), Description = "Bake at 175°C for 30 minutes and let cool.", FoodId = chocolateCakeFoodId },
            new Recipe { Id = Guid.NewGuid(), Description = "Prepare the pie crust and slice apples.", FoodId = applePieFoodId },
            new Recipe { Id = Guid.NewGuid(), Description = "Bake at 180°C for 45 minutes until golden brown.", FoodId = applePieFoodId }

        );
    }
}
