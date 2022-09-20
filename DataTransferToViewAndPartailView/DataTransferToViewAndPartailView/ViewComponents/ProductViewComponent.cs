using DataTransferToViewAndPartailView.Data;
using Microsoft.AspNetCore.Mvc;

namespace DataTransferToViewAndPartailView.ViewComponents;
public class ProductViewComponent : ViewComponent
{
     
    public IViewComponentResult Invoke(int model)
    {
        northwindContext _context = new northwindContext(); 
        return View(model: _context.Products.Where(x => x.CategoryId == model));
    }
}
