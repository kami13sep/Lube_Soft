using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LubeSoft.Model;
using LubeSoft.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LubeSoft.Pages
{
    public class EditVehicleModel : PageModel
    {

        public IVehicleDetailsRepo _VehicleDetailsRepo;

        [BindProperty]
        public VehicleDetails vehicleDetail { get; set; }

        public EditVehicleModel( IVehicleDetailsRepo VehicleDetailsRepo)
        {
            _VehicleDetailsRepo = VehicleDetailsRepo;
        }

        public void OnGet(int id)
        {
            vehicleDetail = _VehicleDetailsRepo.GetVehicleDetailsById(id);
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _VehicleDetailsRepo.Update(vehicleDetail);
                return RedirectToPage("Index");
            }

            return Page();
        }
    }
}
