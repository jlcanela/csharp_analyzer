public class InsuranceCompany
{
    public int CompanyId { get; set; }
    public string Name { get; set; }
    public string LicenseNumber { get; set; }
    public List<Policy> Policies { get; set; }
    public List<Claim> Claims { get; set; }
}
