using LubeSoft.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LubeSoft.Services
{
    public interface IVehicleDetailsRepo
    {
         IEnumerable<VehicleDetails> GetVehicleDetails(string Keyword);
    }

    public class VehicleDetailsRepo : IVehicleDetailsRepo
    {
        private List<VehicleDetails> details;

        public VehicleDetailsRepo()
        {
            details = new List<VehicleDetails>()
            {
            new VehicleDetails(){Vehicle_Id = "abc1",         Customer_Name ="Name1",          Phone ="123456",   Phone_Type = "work",         Vehicle_Details ="details1", VIN ="VIN1",Service_Date =DateTime.Now.AddDays(-1) },
            new VehicleDetails(){Vehicle_Id = "abc2",         Customer_Name ="Name2",          Phone ="123456",   Phone_Type = "phone",         Vehicle_Details ="details2", VIN ="VIN2",Service_Date =DateTime.Now.AddDays(-2) },
            new VehicleDetails(){Vehicle_Id = "abc3",         Customer_Name ="Name3",          Phone ="123456",   Phone_Type = "work",         Vehicle_Details ="details3", VIN ="VIN3",Service_Date =DateTime.Now.AddDays(-3) },
            new VehicleDetails(){Vehicle_Id = "abc4",         Customer_Name ="Name4",          Phone ="123456",   Phone_Type = "phone",         Vehicle_Details ="details4", VIN ="VIN4",Service_Date =DateTime.Now.AddDays(-4) },
            new VehicleDetails(){Vehicle_Id = "abc5",         Customer_Name ="Name5",          Phone ="123456",   Phone_Type = "work",         Vehicle_Details ="details5", VIN ="VIN5",Service_Date =DateTime.Now.AddDays(-5) }
            };
        }
        public IEnumerable<VehicleDetails> GetVehicleDetails(string Keyword)
        {
            if (string.IsNullOrEmpty(Keyword))
            {
                return details;
            }

            return details.Where(p => p.Customer_Name.ToLower().Contains(Keyword.ToLower()) || p.Vehicle_Id.ToLower().Contains(Keyword.ToLower()) || p.VIN.ToLower().Contains(Keyword.ToLower())).OrderByDescending(p => p.Service_Date);
        }
    }
}
