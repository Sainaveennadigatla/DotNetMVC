namespace IdentityApplication.Models
{
    public class invoice
    {
        public int InvoiceId { get; set; }
        public double InvoiceAmount { get; set; }
        public string InvoiceMonth { get; set; }
        public string InvoiceOwner { get; set; }
        public string CreatorId { get; set; }
        public InvoiceStatus Status{get; set; }
    }
    public enum InvoiceStatus
    {
        Submitted,
        approved,
        Rejected
    }
}
