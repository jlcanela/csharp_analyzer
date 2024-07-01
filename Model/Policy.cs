public class Policy
{
    public int PolicyId { get; set; }
    public string PolicyNumber { get; set; }
    public DateTime EffectiveDate { get; set; }
    public DateTime ExpirationDate { get; set; }
    public decimal Premium { get; set; }
    public PolicyType Type { get; set; }
    public List<Coverage> Coverages { get; set; }
    public Policyholder Policyholder { get; set; }
}

public class Policyholder
{
    public int PolicyholderId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
}

public class Coverage
{
    public int CoverageId { get; set; }
    public string Type { get; set; }
    public decimal Limit { get; set; }
    public decimal Deductible { get; set; }
}

public enum PolicyType
{
    Auto,
    Home,
    Life,
    Health
}
