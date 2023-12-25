# Movie Recommendation System API

Welcome to the Movie Recommendation System API! This API provides powerful features to query and recommend movies based on various criteria such as movie name, genre, keywords, and ratings.

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)

### Installation

1. **Clone the Repository:**

   ```bash
   git clone https://github.com/your-username/movie-recommendation-api.git
   cd movie-recommendation-api
Restore Dependencies:

bash
Copy code
dotnet restore
Apply Database Migrations:

bash
Copy code
dotnet ef database update
Run the API:

bash
Copy code
dotnet run
The API will be available at http://localhost:5000.

Usage
Query Movies
To query movies, send a POST request to /api/movies/query with a JSON body containing the query parameters. Example:

json
Copy code
{
  "movieName": "Inception",
  "genre": "Action",
  "keyword": "dream",
  "minRating": 4.0,
  "maxResults": 10
}
This endpoint retrieves detailed information about a specific movie and related data such as genres, ratings, production countries, and production companies.

Recommendations
To get movie recommendations, use the /api/movies/recommend endpoint. Example:

json
Copy code
{
  "movieName": "Inception",
  "genre": "Action",
  "keyword": "dream",
  "minRating": 4.0,
  "maxResults": 10
}
This endpoint provides recommendations based on the input movie's genre, keywords, and minimum rating. It includes a list of recommended movies with their metadata.

Contributing
Fork the repository.
Create a new branch: git checkout -b feature/new-feature.
Make your changes and commit: git commit -m 'Add new feature'.
Push to the branch: git push origin feature/new-feature.
Create a pull request.
License
This project is licensed under the MIT License.

sql
Copy code
-- SQL code for your database schema goes here
You can copy and paste this into your README file. Feel free to customize it further based on your specific API implementation.