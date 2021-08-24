using LubeSoft.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LubeSoft.Services
{
    public interface IVehicleDetailsRepo
    {
         IEnumerable<VehicleDetails> GetVehicleDetails(string Keyword);
        VehicleDetails GetVehicleDetailsById(int id);
        void Update(VehicleDetails vehicleDetail);
    }

    public class VehicleDetailsRepo : IVehicleDetailsRepo
    {
        private List<VehicleDetails> details;

        public VehicleDetailsRepo()
        {
            details = new List<VehicleDetails>()
            {
            new VehicleDetails(){Id= 1, Vehicle_Id = "abc1",         Customer_Name ="Name1",          Phone ="123456",        Vehicle_Details ="details1", VIN ="VIN1",Service_Date =DateTime.Now.AddDays(-1) },
            new VehicleDetails(){Id= 2, Vehicle_Id = "abc2",         Customer_Name ="Name2",          Phone ="123456",        Vehicle_Details ="details2", VIN ="VIN2",Service_Date =DateTime.Now.AddDays(-2) },
            new VehicleDetails(){Id= 3, Vehicle_Id = "abc3",         Customer_Name ="Name3",          Phone ="123456",        Vehicle_Details ="details3", VIN ="VIN3",Service_Date =DateTime.Now.AddDays(-3) },
            new VehicleDetails(){Id= 4, Vehicle_Id = "abc4",         Customer_Name ="Name4",          Phone ="123456",        Vehicle_Details ="details4", VIN ="VIN4",Service_Date =DateTime.Now.AddDays(-4) },
            new VehicleDetails(){Id= 5, Vehicle_Id = "abc5",         Customer_Name ="Name5",          Phone ="123456",        Vehicle_Details ="details5", VIN ="VIN5",Service_Date =DateTime.Now.AddDays(-5) }
            };
        }
        public IEnumerable<VehicleDetails> GetVehicleDetails(string Keyword)
        {
            if (string.IsNullOrEmpty(Keyword))
            {
                return details.OrderByDescending(p => p.Service_Date);
            }

            return details.Where(p => p.Customer_Name.ToLower().Contains(Keyword.ToLower()) || p.Vehicle_Id.ToLower().Contains(Keyword.ToLower()) || p.VIN.ToLower().Contains(Keyword.ToLower())).OrderByDescending(p => p.Service_Date);
        }

        public VehicleDetails GetVehicleDetailsById(int id)
        {
            return details.FirstOrDefault(p => p.Id == id);
        }

        public void Update(VehicleDetails vehicleDetail)
        {
            VehicleDetails details = GetVehicleDetailsById(vehicleDetail.Id);

            if (details != null)
            {
                details.Vehicle_Id = vehicleDetail.Vehicle_Id;
                details.Customer_Name = vehicleDetail.Customer_Name;
                details.Phone = vehicleDetail.Phone;
                details.Vehicle_Details = vehicleDetail.Vehicle_Details;
                details.VIN = vehicleDetail.VIN;
                details.Service_Date = vehicleDetail.Service_Date;

            }
        }
    }
}
