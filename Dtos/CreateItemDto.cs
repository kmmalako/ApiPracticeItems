using System.ComponentModel.DataAnnotations;
namespace Catalog.Dtos
{
    public record CreateItemDto
    {

        [Required]  //Protect values coming (dont want null)
        public string Name { get; init;}

        [Required]
        [Range(1, 1000)]  //Dont want negative price
        public decimal Price {get; init;}
    }
}