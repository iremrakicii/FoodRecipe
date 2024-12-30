function loadWelcomePage() {
    const content = document.getElementById("content");
    content.innerHTML = `
    <div class="welcome-screen">
      <video autoplay muted loop class="background-video">
        <source src="https://media.istockphoto.com/id/1371539996/tr/video/vertical-food-preparation-blog-montage-for-social-media-montage-multiple-screens.mp4?s=mp4-640x640-is&k=20&c=zrVZzuIawak8w2YUXKy3DA70M1teO7i7pN4xXyjP8cE=" type="video/mp4">
        Your browser does not support the video tag.
      </video>
      <div class="welcome-content">
        <h1>İrem's Delicious Recipes</h1>
        <p>Explore the most delicious dishes from around the world!</p>
        <button class="start-btn" onclick="loadFoods()">Start Exploring</button>
      </div>
    </div>
  `;
}


async function loadFoods() {
    const content = document.getElementById("content");
    try {
        
        const response = await fetch("https://localhost:7251/food/get-all"); 
        if (!response.ok) throw new Error("Failed to fetch foods");

        const foods = await response.json(); 

        
        content.innerHTML = `
            <h1 class="food-header">Explore <span>Our Delicious Foods</span></h1>
            <div class="grid-container">
              ${foods
                .map(
                    (food) => `
                <div class="food-card">
                  <img src="${food.foodPhoto || 'default-image.jpg'}" alt="${food.foodName}">
                  <h2>${food.foodName}</h2>
                  <p>${food.foodVariety}</p>
                  <button class="view-recipes-btn" onclick="loadRecipes('${food.id}')">View Recipes</button>
                </div>
              `
                )
                .join("")}
            </div>
        `;
    } catch (error) {
        console.error("Error loading foods:", error);
        content.innerHTML = `<p>Failed to load foods. Please try again later.</p>`;
    }
}



async function loadRecipes(foodId) {
    const content = document.getElementById("content");

    try {
        
        const response = await fetch(`https://localhost:7251/get/${foodId}`); 
        if (!response.ok) throw new Error("Failed to fetch recipes");

        
        const food = await response.json();

        if (!food || !food.recipes || food.recipes.length === 0) {
            content.innerHTML = `<p>Recipes not found for this food.</p>`;
            return;
        }

       
        content.innerHTML = `
            <div class="recipe-header">
                <h1>${food.foodName} Recipes</h1>
                <p>${food.foodVariety} Cuisine</p>
                <img src="${food.foodPhoto || 'default-image.jpg'}" alt="${food.foodName}">
            </div>
            <div class="recipe-container">
                ${food.recipes
                .map(
                    (recipe, index) => `
                    <div class="recipe-card">
                        <span class="recipe-step">Step ${index + 1}</span>
                        <p>${recipe.description}</p>
                    </div>
                `
                )
                .join("")}
            </div>
            <button class="back-to-foods-btn" onclick="loadFoods()">Back to Foods</button>
        `;
    } catch (error) {
        console.error("Error loading recipes:", error);
        content.innerHTML = `<p>Failed to load recipes. Please try again later.</p>`;
    }
}

loadWelcomePage();

