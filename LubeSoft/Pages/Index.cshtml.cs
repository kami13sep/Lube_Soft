using LubeSoft.Model;
using LubeSoft.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LubeSoft.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public IVehicleDetailsRepo _VehicleDetailsRepo;
        
        [BindProperty(SupportsGet =true)]
        public string SearchKeyword { get; set; }
        public IEnumerable<VehicleDetails> vehicleDetails;

        public IndexModel(ILogger<IndexModel> logger, IVehicleDetailsRepo VehicleDetailsRepo)
        {
            _logger = logger;
            _VehicleDetailsRepo = VehicleDetailsRepo;
        }


        
        public void OnGet()
        {
            vehicleDetails = _VehicleDetailsRepo.GetVehicleDetails(SearchKeyword);

        }
       
    }
}
