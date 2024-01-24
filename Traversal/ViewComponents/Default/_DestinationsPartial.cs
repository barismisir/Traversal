using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Default
{
    public class _DestinationsPartial:ViewComponent
    {
        DestinationService _destinationManager;

        public _DestinationsPartial(DestinationService destinationManager)
        {
            _destinationManager = destinationManager;
        }

        public IViewComponentResult Invoke()
        {
            return View(_destinationManager.GetAll());
        }
    }
}
