using System;  
using System.Collections.Generic;  

namespace VehicleInsuranceApi.Models  
{  
    public class InsurancePolicy  
    {  
        public string PolicyNumber { get; set; }  
        public string CustomerId { get; set; }  
        public string VehicleId { get; set; }  
        public string InsuranceType { get; set; }  
        public decimal PremiumAmount { get; set; }  
        public decimal CoverageLimit { get; set; }  
        public DateTime StartDate { get; set; }  
        public DateTime EndDate { get; set; }  
        public string Status { get; set; }  
        public decimal Deductible { get; set; }  
        public DateTime CreatedAt { get; set; }  
        public DateTime UpdatedAt { get; set; }  

        // Navigation properties  
        public virtual Customer Customer { get; set; }  
        public virtual Vehicle Vehicle { get; set; }  
        public virtual ICollection<Claim> Claims { get; set; }  
        public virtual ICollection<Payment> Payments { get; set; }  
    }  
}  
