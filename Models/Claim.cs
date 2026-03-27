using System;

namespace VehicleInsuranceApi.Models
{
    public class Claim
    {
        public int Id { get; set; }
        public string PolicyNumber { get; set; }
        public string ClaimantName { get; set; }
        public DateTime ClaimDate { get; set; }
        public decimal ClaimAmount { get; set; }
        public string Status { get; set; }

        public Claim(int id, string policyNumber, string claimantName, DateTime claimDate, decimal claimAmount)
        {
            Id = id;
            PolicyNumber = policyNumber;
            ClaimantName = claimantName;
            ClaimDate = claimDate;
            ClaimAmount = claimAmount;
            Status = "Pending"; // Default status when claim is created
        }

        public void ApproveClaim()
        {
            Status = "Approved";
        }

        public void RejectClaim()
        {
            Status = "Rejected";
        }
    }
}