using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SmartDevicesReturn.Data;
using SmartDevicesReturn.Model;

namespace SmartDevicesReturn.Pages.DeviceReturn
{
    public class IndexModel : PageModel
    {
        public readonly ApplicationDbContext _db;

        public IEnumerable<DeviceCategory> CategoryReturn { get; set; }
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            CategoryReturn = _db.DeviceCategory;
        }
    }
}
