using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RentACar.WebApp.Models.ViewModels.Transmissions;
using RentACar.WebApp.Repositories.Abstract;

namespace RentACar.WebApp.Views.Shared.ViewComponents;

public class TransmissionSelectListViewComponent : ViewComponent
{

    private readonly ITransmissionRepository _transmissionRepository;

    public TransmissionSelectListViewComponent(ITransmissionRepository transmissionRepository)
    {
        _transmissionRepository = transmissionRepository;
    }

    public IViewComponentResult Invoke(int selectedTransmissionId)
    {
        var transmissions = _transmissionRepository.GetAll();

        var items = new SelectList(transmissions,"Id","Name",selectedTransmissionId);

        TransmissionSelectViewModel model = new()
        {
            TransmissionId = selectedTransmissionId,
            Transmissions = items
        };

        return View(model);
    }
    
    
}