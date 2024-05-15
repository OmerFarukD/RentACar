using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RentACar.WebApp.Models.ViewModels.Fuels;
using RentACar.WebApp.Repositories.Abstract;

namespace RentACar.WebApp.Views.Shared.ViewComponents;

public class FuelSelectListViewComponent : ViewComponent
{

    private readonly IFuelRepository _fuelRepository;

    public FuelSelectListViewComponent(IFuelRepository fuelRepository)
    {
        _fuelRepository = fuelRepository;
    }

    public IViewComponentResult Invoke(int selectedFuelId)
    {
        var fuels = _fuelRepository.GetAll();
        var items = new SelectList(fuels, "Id", "Name", selectedFuelId);

        FuelSelectViewModel model = new()
        {
            FuelId = selectedFuelId,
            Fuels = items
        };
        return View(model);
    }
    
}