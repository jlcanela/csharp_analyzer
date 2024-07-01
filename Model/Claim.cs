public class Claim
{
    public int ClaimId { get; set; }
    public string ClaimNumber { get; set; }
    public DateTime DateOfLoss { get; set; }
    public DateTime DateReported { get; set; }
    public string Description { get; set; }
    public ClaimStatus Status { get; set; }
    public decimal EstimatedAmount { get; set; }
    public Policy RelatedPolicy { get; set; }
    public List<ClaimDocument> Documents { get; set; }
}

public class ClaimDocument
{
    public int DocumentId { get; set; }
    public string FileName { get; set; }
    public string FileType { get; set; }
    public DateTime UploadDate { get; set; }
}

public enum ClaimStatus
{
    Open,
    UnderInvestigation,
    Approved,
    Denied,
    Closed
}
