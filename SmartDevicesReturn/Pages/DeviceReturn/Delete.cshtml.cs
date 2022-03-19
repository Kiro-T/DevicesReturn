using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SmartDevicesReturn.Data;
using SmartDevicesReturn.Model;

namespace SmartDevicesReturn.Pages.DeviceReturn;

public class DeleteModel : PageModel
{
    private readonly ApplicationDbContext _db;
    [BindProperty]
    public DeviceCategory DeviceCategory { get; set; }
    public DeleteModel(ApplicationDbContext db)
    {
        _db = db;
    }
    public void OnGet(int id)
    {
        DeviceCategory = _db.DeviceCategory.Find(id);
    }

    public async Task<IActionResult> OnPost()
    {
       
            var deviceCategoryFromDb = _db.DeviceCategory.Find(DeviceCategory.Id);
            if(deviceCategoryFromDb != null)
            {
                _db.DeviceCategory.Remove(deviceCategoryFromDb);
                await _db.SaveChangesAsync();
                TempData["success"] = "Return Device deleted successfully";
                return RedirectToPage ("Index");
            }
        
     
        return Page();
    }
}
