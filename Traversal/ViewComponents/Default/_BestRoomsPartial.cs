using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Default
{
    public class _BestRoomsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
