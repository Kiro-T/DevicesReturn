using System.ComponentModel.DataAnnotations;

namespace SmartDevicesReturn.Model
{
    public class DeviceCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name="Accepted By")]
        public string acceptedBy { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Date Received")]
        public DateTime dateReceived { get; set; }

        [Required]
        [Display(Name = "User Name")]
        [MaxLength(50)]
        public string userName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "E-Mail")]
        [MaxLength(20)]
        public string email { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Ticket No.")]
        [MaxLength(6)]
        public string ticketNo { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Service Category")]
        [MaxLength(10)]
        public string serviceCategory { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Device Type")]
        [MaxLength(24)]
        public string deviceType { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Device IMEI/DAMS/Serial No.")]
        [MaxLength(30)]
        public string deviceId { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Phone/SIM No.")]
        [MaxLength(20)]
        public string phoneNo { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Description")]
        [MaxLength(100)]
        public string faultDescription { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Action Required")]
        [MaxLength(100)]
        public string actionRequired { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Device Status")]
        [MaxLength(20)]
        public string deviceStatus { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Stock")]
        public bool Stock { get; set; }

        [Required]
        [Display(Name = "Collection")]
        public bool Collection { get; set; }

        [Required]
        [Display(Name = "Posted")]
        public bool Post { get; set; }

        [Required]
        [Display(Name = "Date Actioned")]
        public DateTime dateActioned { get; set; }

    }
}
