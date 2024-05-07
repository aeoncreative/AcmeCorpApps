using System.Diagnostics.CodeAnalysis;

namespace SaleMakerApp.Entities
{
    public class Models
    {
        //borrowed code, contains some sample product, customer models as well as a DTO

        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            // Other domain-specific properties and methods
        }

        //added code to show inheritance
        public class Service : Product
        {
        }

        public class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
            // Other entity-specific properties and methods

            public Contact ContactInfo { get; set; }

            public void UpdateName(string newName)
            {
                // Validate the name and apply business rules if necessary
                this.Name = newName;
            }
        }

        public class ProductDTO
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
        }

        // Usage in a hypothetical service class
        public class ProductService
        {
            // Method to retrieve a list of products as DTOs
            public List<ProductDTO> GetProducts()
            {
                // In a real application, you might fetch products from a database or other sources
                var products = new List<Product>
        {
            new Product { Id = 1, Name = "Product A", Price = 10.99M },
            new Product { Id = 2, Name = "Product B", Price = 24.50M },
            // ...
        };

                // Mapping Domain Objects (Product) to DTOs (ProductDTO)
                var productDTOs = products.Select(p => new ProductDTO
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price
                }).ToList();

                return productDTOs;
            }
        }

        public class Order
        {
            public int Id { get; set; }
            public Customer customer { get; set; }

            public List<Product> products { get; set; }


        }

        public class Contact
        {
            public string PhoneNumber { get; set; }
            public string EmailAddress { get; set; }

        }
    }
}

namespace SaleMakerApp.SimpleJWT
{
    public class User
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;

        }

    }

}
