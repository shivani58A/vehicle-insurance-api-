// Insurance Policy Data Transfer Object
public class InsurancePolicyDTO {
    public string PolicyNumber { get; set; }
    public string InsuredName { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal Premium { get; set; }
}