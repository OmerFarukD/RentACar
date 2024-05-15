using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RentACar.WebApp.Models.ViewModels.Colors;
using RentACar.WebApp.Repositories.Abstract;

namespace RentACar.WebApp.Views.Shared.ViewComponents;

public class ColorSelectListViewComponent : ViewComponent
{
    private readonly IColorRepository _colorRepository;

    public ColorSelectListViewComponent(IColorRepository colorRepository)
    {
        _colorRepository = colorRepository;
    }


    public IViewComponentResult Invoke(int selectedColorId)
    {
        var colors = _colorRepository.GetAll();

        var items = new SelectList(colors,"Id","Name",selectedColorId);

        ColorSelectViewModel model = new()
        {
            ColorId = selectedColorId,
            Colors = items
        };
        return View(model);
    }
    
}