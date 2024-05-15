using RentACar.WebApp.Models.Entities;

namespace RentACar.WebApp.Models.Dtos.Responses;

public record CategoryResponseDto(int Id, string Name)
{

    public static implicit operator CategoryResponseDto(Category category)
    {
        return new CategoryResponseDto(category.Id, category.Name);
    }

}