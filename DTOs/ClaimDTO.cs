// Claim Data Transfer Object
public class ClaimDTO {
    public string ClaimNumber { get; set; }
    public string PolicyNumber { get; set; }
    public DateTime ClaimDate { get; set; }
    public decimal ClaimAmount { get; set; }
    public string Status { get; set; }
}