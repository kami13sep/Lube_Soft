using System;
using System.ComponentModel.DataAnnotations;

namespace LubeSoft.Model
{
    public class VehicleDetails
    {
        [Required]
        public int Id { get; set; }
        
        [Required(ErrorMessage ="Please Enter valid Vehicle Id")]
        public string Vehicle_Id { get; set; }

        [Required(ErrorMessage = "Please Enter valid Customer Name")]
        public string Customer_Name { get; set; }

        [Required(ErrorMessage = "Please Enter valid Phone Number")]
        public string Phone { get; set; }

        //[Required]
        //public string Phone_Type { get; set; }

        [Required(ErrorMessage = "Please Enter valid Vehicle Idetails")]
        public string Vehicle_Details { get; set; }

        [Required(ErrorMessage = "Please Enter valid VIN")]
        public string VIN { get; set; }

        [Required(ErrorMessage = "Please Enter valid Service Date")]
        [DataType(DataType.Date)]
        public DateTime Service_Date { get; set; }
    }
}
