# ApiMongoDb

This is a sample API built with .NET 6 that provides CRUD (Create, Read, Update, Delete) operations for managing products using MongoDB as the database. It demonstrates the use of AutoMapper for object mapping, the Repository Pattern for data access, and Services for encapsulating business logic.

## Features

- **Create**: Add a new product to the database.
- **Read**: Retrieve a list of all products or a specific product by its ID.
- **Update**: Update an existing product's information.
- **Delete**: Remove a product from the database.

## Technologies Used

- .NET 6
- MongoDB: A NoSQL database for storing product data.
- AutoMapper: Used for mapping between DTOs (Data Transfer Objects) and domain models.
- Repository Pattern: Separation of data access logic from business logic.
- Dependency Injection: Utilized to manage the application's services.

## Prerequisites

- .NET 6 SDK: Make sure you have .NET 6 installed on your machine. You can download it [here](https://dotnet.microsoft.com/download/dotnet/6.0).
- MongoDB: You need a running MongoDB instance. You can use a locally installed MongoDB server or run it in a Docker container.

## Getting Started

1. **Clone the Repository**:

   ```bash
   git clone https://github.com/guilhermebernava/ApiMongo.git
   ```

2. **Update AppSettings**:

   Open the `appsettings.json` file and configure the MongoDB connection string and database name.

   ```json
   "ConnectionStrings": {
       "MongoDB": "mongodb://localhost:27017"
   },
   "DatabaseSettings": {
       "DatabaseName": "YourDatabaseName",
       "CollectionName": "Products"
   }
   ```

3. **Run the API**:

   ```bash
   dotnet run
   ```

   The API will be accessible at `http://localhost:5000` by default. You can use tools like Postman or cURL to interact with the API endpoints.

## API Endpoints

- **GET /api/products**: Get a list of all products.
- **GET /api/products/{id}**: Get a product by its ID.
- **POST /api/products**: Create a new product.
- **PUT /api/products/{id}**: Update an existing product.
- **DELETE /api/products/{id}**: Delete a product by its ID.

## Usage Examples

Here are some examples of how to use the API endpoints:

### Create a Product

```http
POST /api/products
Content-Type: application/json

{
    "name": "Product Name",
    "price": 19.99
}
```

### Get a List of All Products

```http
GET /api/products
```

### Get a Product by ID

```http
GET /api/products/{id}
```

### Update a Product

```http
PUT /api/products/{id}
Content-Type: application/json

{
    "name": "Updated Product Name",
    "price": 29.99
}
```

### Delete a Product by ID

```http
DELETE /api/products/{id}
```

---
