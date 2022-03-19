using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SmartDevicesReturn.Data;
using SmartDevicesReturn.Model;

namespace SmartDevicesReturn.Pages.DeviceReturn;

public class CreateModel : PageModel
{
    private readonly ApplicationDbContext _db;
    [BindProperty]
    public DeviceCategory DeviceCategory { get; set; }
    public CreateModel(ApplicationDbContext db)
    {
        _db = db;
    }
    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPost()
    {
        if (DeviceCategory.acceptedBy == DeviceCategory.userName.ToString())
        {
            ModelState.AddModelError(string.Empty, "The 'Accepted By' cannot match the 'User Name'");
        }
        if(ModelState.IsValid)
        { 
            await _db.DeviceCategory.AddAsync(DeviceCategory);
            await _db.SaveChangesAsync();
            TempData["success"] = "Return Device created successfully";
            return RedirectToPage ("Index");
        }
        return Page();
    }
}
