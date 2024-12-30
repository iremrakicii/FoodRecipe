# İrem's Delicious Recipes

Welcome to **İrem's Delicious Recipes**! This is a web application where you can explore a variety of recipes from around the world. Whether you're in the mood for desserts, healthy bowls, or savory snacks, there's something for everyone.

---

## Features
- Browse a wide selection of recipes categorized by type and cuisine.
- View step-by-step instructions for each recipe.
- Enjoy an elegant and user-friendly interface.

---

## Screenshots

### Home Page
![Home Page](./Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202024-12-30%20165427.png)
*Explore the most delicious dishes from around the world!*

### Recipe Categories
![Recipe Categories](./Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202024-12-30%20165441.png)
*Discover a variety of recipes organized by category.*

### Dubai Chocolate Recipe
![Dubai Chocolate Recipe](./Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202024-12-30%20165451.png)
*Follow detailed steps to create Dubai Chocolate.*

### Falafel Recipe
![Falafel Recipe](./Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202024-12-30%20165503.png)
*Learn how to make authentic Middle Eastern falafel.*

---

## Project Structure

### Backend
The backend is built using ASP.NET Core. It provides APIs for managing foods and recipes.

#### Controllers
- **FoodApiController**: Handles operations for managing food items (e.g., adding, updating, and deleting foods).
- **RecipeController**: Handles operations for managing recipes (e.g., adding, updating, and deleting recipes).

#### Data Models
- **Food**: Represents a food item with attributes like `FoodName`, `FoodVariety`, and associated recipes.
- **Recipe**: Represents a recipe with attributes like `Description` and associated food.

#### Database Configuration
The project uses Entity Framework Core for database management.

---

## How to Run

### Backend
1. Clone the repository:
   ```bash
   git clone https://github.com/iremrakicii/FoodRecipe.git
   ```
2. Navigate to the backend directory and restore dependencies:
   ```bash
   cd FoodRecipe
   dotnet restore
   ```
3. Run the backend server:
   ```bash
   dotnet run
   ```

### Frontend
1. Navigate to the project root directory.
2. Open the `index.html` file in your browser to start exploring the recipes.

---

## Technologies Used
- **Backend**: ASP.NET Core, Entity Framework Core
- **Frontend**: HTML, CSS, JavaScript
- **Database**: Microsoft SQL Server

---

## API Endpoints

### Food API
- `GET /get/{id}`: Fetch a specific food item by ID.
- `GET /get-by-name/{name}`: Fetch a food item by name.
- `GET /get-all`: Fetch all food items.
- `POST /add`: Add a new food item.
- `DELETE /delete/{id}`: Delete a food item by ID.
- `PUT /update-name`: Update the name of a food item.

### Recipe API
- `GET /get-recipe/{id}`: Fetch a specific recipe by ID.
- `GET /get-recipe-by-food-id/{foodid}`: Fetch recipes by food ID.
- `GET /get-by-description/{description}`: Fetch a recipe by description.
- `GET /get-all-recipe`: Fetch all recipes.
- `POST /recipe-add`: Add a new recipe.
- `DELETE /delete-recipe/{id}`: Delete a recipe by ID.
- `PUT /update-description`: Update the description of a recipe.

---

## Contributing
If you'd like to contribute to this project, feel free to fork the repository and submit a pull request. Contributions are always welcome!

---

## License
This project is licensed under the MIT License. See the LICENSE file for details.

---

