using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SmartDevicesReturn.Data;
using SmartDevicesReturn.Model;

namespace SmartDevicesReturn.Pages.DeviceReturn;

public class EditModel : PageModel
{
    private readonly ApplicationDbContext _db;
    [BindProperty]
    public DeviceCategory DeviceCategory { get; set; }
    public EditModel(ApplicationDbContext db)
    {
        _db = db;
    }
    public void OnGet(int id)
    {
        DeviceCategory = _db.DeviceCategory.Find(id);
    }

    public async Task<IActionResult> OnPost()
    {
        if (DeviceCategory.acceptedBy == DeviceCategory.userName.ToString())
        {
            ModelState.AddModelError(string.Empty, "The 'Accepted By' cannot match the 'User Name'");
        }
        if(ModelState.IsValid)
        { 
            _db.DeviceCategory.Update(DeviceCategory);
            await _db.SaveChangesAsync();
            TempData["success"] = "Return Device updated successfully";
            return RedirectToPage ("Index");
        }
        return Page();
    }
}
