using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RentACar.WebApp.Helpers;

public class EnumHelpers
{
    public static SelectList GetEnumSelectList<T>() where T : Enum
    {
        var values = Enum.GetValues(typeof(T)).Cast<T>()
            .Select(e => new {
                Id = Convert.ToInt32(e),
                Name = e.GetType().GetField(e.ToString())
                    .GetCustomAttributes(typeof(DisplayAttribute), false)
                    .Cast<DisplayAttribute>()
                    .FirstOrDefault()?.GetName() ?? e.ToString()
            });

        return new SelectList(values, "Id", "Name");
    }
}