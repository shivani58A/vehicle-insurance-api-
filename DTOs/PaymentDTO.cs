// Payment Data Transfer Object
public class PaymentDTO {
    public string PaymentId { get; set; }
    public string PolicyNumber { get; set; }
    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }
}